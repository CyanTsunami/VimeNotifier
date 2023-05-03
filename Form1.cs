using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VimeNotifier {
    public partial class Form1: Form {
        private Properties.Settings settings = Properties.Settings.Default;
        private Regex userLineRegex, logRemoveRegex, DMRegex, chatRegex;
        private BackgroundWorker chatWorker, apiWorker;
        private SoundPlayer player;
        private string logsPath, chatSoundPath, gameSoundPath, username;

        public Form1() {
            InitializeComponent();
            string systemUsername = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            logsPath = "C:\\Users\\" + systemUsername.Substring(systemUsername.LastIndexOf('\\') + 1) +
                       "\\AppData\\Roaming\\.vimeworld\\{0}\\logs\\latest.log";
            chatSoundLabel.Text = chatSoundPath = !File.Exists(settings.chatSoundPath) ?
                settings.chatSoundPath :
                "C:\\Windows\\Media\\Windows Proximity Notification.wav";
            gameSoundLabel.Text = gameSoundPath = !File.Exists(settings.gameSoundPath) ?
                settings.gameSoundPath :
                "C:\\Windows\\Media\\Windows Proximity Notification.wav";
            DMFlagCheckBox.Checked = settings.DMFlagCheckBox;
            ChatFlagCheckBox.Checked = settings.ChatFlagCheckBox;
            serverComboBox.Text = settings.serverComboBox;

            userLineRegex = new Regex(
                "^\\[\\d{2}:\\d{2}:\\d{2}\\]( \\[[\\w .\\/]*\\])*: " +
                "Setting user: \\w{3,16}");
            logRemoveRegex = new Regex(
                "^\\[\\d{2}:\\d{2}:\\d{2}\\]( \\[[\\w .\\/]*\\])*: \\[CHAT\\] " +
                "(\\(Всем\\) |<.{1,}> )?(\\[.{1,4}\\] )?");
            DMRegex = new Regex(
                "^\\[\\d{2}:\\d{2}:\\d{2}\\]( \\[[\\w .\\/]*\\])*: \\[CHAT\\] " +
                "\\[[\\w\\d]{3,16} -> Вы\\] .*$");
            chatRegex = new Regex(
                "^\\[\\d{2}:\\d{2}:\\d{2}\\]( \\[[\\w .\\/]*\\])*: \\[CHAT\\]" +
                "( \\(Всем\\)| <.{1,5}>)?( \\[.{1,4}\\])? [\\w\\d]{3,16}: .*$");

            chatWorker = new BackgroundWorker {
                WorkerSupportsCancellation = true
            };
            chatWorker.DoWork += new DoWorkEventHandler(chatHandler);
            apiWorker = new BackgroundWorker {
                WorkerSupportsCancellation = true
            };
            apiWorker.DoWork += new DoWorkEventHandler(apiHandler);
            player = new SoundPlayer(chatSoundPath);

            settings.chatSoundPath = chatSoundPath;
            settings.gameSoundPath = gameSoundPath;
            settings.Save();
        }

        public IEnumerable<string> ReadLines(StreamReader reader) {
            string line;
            while((line = reader.ReadLine()) != null) {
                yield return line;
            }
        }

        public string getUsername(string filepath) {
            Stream stream = new FileStream(filepath, FileMode.Open,
                                           FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string result = string.Empty;
            foreach(string line in ReadLines(reader)) {
                if(userLineRegex.Match(line).Success) {
                    int index = line.IndexOf("Setting user:");
                    result = line.Substring(index + 14);
                    break;
                }
            }
            reader.Close();
            stream.Close();
            return result;
        }

        private void FlagCheckBox_CheckedChanged(object sender, EventArgs e) {
            CheckBox box = (CheckBox)sender;
            settings[box.Name] = box.Checked;
            settings.Save();
        }

        private void soundLabel_TextChanged(object sender, EventArgs e) {
            Label label = (Label)sender;
            label.Text = label.Text.Substring(label.Text.LastIndexOf('\\') + 1);
        }

        private void setDefaultChatSoundButton_Click(object sender, EventArgs e) {
            chatSoundLabel.Text = chatSoundPath = settings.chatSoundPath = 
                "C:\\Windows\\Media\\Windows Proximity Notification.wav";
            settings.Save();
        }

        private void setDefaultGameSoundButton_Click(object sender, EventArgs e) {
            gameSoundLabel.Text = gameSoundPath = settings.gameSoundPath =
                "C:\\Windows\\Media\\Windows Proximity Notification.wav";
            settings.Save();
        }

        public dynamic GetJsonResponse(HttpClient client, string url, ref int code) {
            HttpResponseMessage response = client.GetAsync(url).Result;
            dynamic obj;
            if(!response.IsSuccessStatusCode) {
                obj = response.Content != null ?
                    JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result) : 
                    new JObject();
                code = obj.First != null ? 
                    ((int)obj.First["error"]["error_code"]) : -3;
                return obj;
            }
            obj = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
            code = 0;
            return obj;
        }

        public void safeRestore() {
            if(!InvokeRequired) {
                chatWorker.CancelAsync();

                starterButton.Text = chatWorker.IsBusy ? "Включить" : "Выключить";
                chatNotifyGroupBox.Enabled = chatWorker.IsBusy;
                gameNotifyGroupBox.Enabled = serverComboBox.Text == "Minigames" && chatWorker.IsBusy;
            } else {
                Invoke(new Action(() => safeRestore()));
            }
        }

        private void chatHandler(object sender, DoWorkEventArgs e) {
            Stream stream = new FileStream((string)e.Argument, FileMode.Open,
                                           FileAccess.Read, FileShare.ReadWrite);
            stream.Seek(0, SeekOrigin.End);

            using(StreamReader reader = new StreamReader(stream, Encoding.UTF8)) {
                while(!chatWorker.CancellationPending) {
                    foreach(string templine in ReadLines(reader)) {
                        if((ChatFlagCheckBox.Checked && chatRegex.Match(templine).Success)) {
                            string line = logRemoveRegex.Replace(templine, "");
                            string[] parts = line.Split(new char[] {':'}, 2);
                            if(parts[1].ToLower().Contains(username)) {
                                player.SoundLocation = chatSoundPath;
                                player.Play();
                            }
                        } else if(DMFlagCheckBox.Checked && DMRegex.Match(templine).Success) {
                            player.SoundLocation = chatSoundPath;
                            player.Play();
                        }
                    }
                    Thread.Sleep(500);
                }
            }
            stream.Close();
        }

        private void apiHandler(object sender, DoWorkEventArgs e) {
            using(HttpClient client = new HttpClient()) {
                int code = 0;
                dynamic oldJson = GetJsonResponse(client, 
                    "https://api.vimeworld.com/user/name/" + username, ref code);
                if(code != 0) {
                    safeRestore();
                    MessageBox.Show("Ошибка обращения к API. Код ошибки: " + code.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = ((int)oldJson[0]["id"]);
                oldJson = GetJsonResponse(client, "https://api.vimeworld.com/user/" + id.ToString() +
                    "/session", ref code);
                if(code != 0) {
                    safeRestore();
                    MessageBox.Show("Ошибка обращения к API. Код ошибки: " + code.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                while(!apiWorker.CancellationPending) {
                    Thread.Sleep(2000);
                    dynamic newJson = GetJsonResponse(client, "https://api.vimeworld.com/user/" + id.ToString() +
                        "/session", ref code);
                    if(code != 0) {
                        safeRestore();
                        MessageBox.Show("Ошибка обращения к API. Код ошибки: " + code.ToString(),
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string newMsg = newJson["online"]["message"].ToString();
                    string oldMsg = oldJson["online"]["message"].ToString();
                    if(newMsg != oldMsg && newMsg.ToString() != "Находится в Лобби") {
                        player.SoundLocation = gameSoundPath;
                        player.Play();
                    }
                    oldJson = newJson;
                }
            }
        }

        private void setOwnSoundButton_Click(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.InitialDirectory = chatSoundPath.Remove(chatSoundPath.LastIndexOf('\\'));
                dialog.Filter = ".wav файлы (*.wav)|*.wav";
                dialog.FilterIndex = 0;
                dialog.RestoreDirectory = true;
                if(dialog.ShowDialog() == DialogResult.OK) {
                    chatSoundLabel.Text = settings.chatSoundPath = chatSoundPath = dialog.FileName;
                    settings.Save();
                }
            }
        }

        private void setOwnGameSoundButton_Click(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.InitialDirectory = chatSoundPath.Remove(chatSoundPath.LastIndexOf('\\'));
                dialog.Filter = ".wav файлы (*.wav)|*.wav";
                dialog.FilterIndex = 0;
                dialog.RestoreDirectory = true;
                if(dialog.ShowDialog() == DialogResult.OK) {
                    gameSoundLabel.Text = settings.gameSoundPath = gameSoundPath = dialog.FileName;
                    settings.Save();
                }
            }
        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            gameNotifyGroupBox.Enabled = serverComboBox.Text == "Minigames";
            settings.serverComboBox = serverComboBox.Text;
            settings.Save();
        }

        private async void starterButton_Click(object sender, EventArgs e) {
            string path = string.Format(logsPath, serverComboBox.Text.ToLower());
            if(!File.Exists(path)) {
                MessageBox.Show("Файл не существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            username = getUsername(path);
            if(username == string.Empty) {
                MessageBox.Show("Не удалось найти никнейм", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usernameLabel.Text = username;
            username = username.ToLower();

            starterButton.Text = chatWorker.IsBusy ? "Включить" : "Выключить";
            starterButton.Enabled = false;
            serverComboBox.Enabled = chatNotifyGroupBox.Enabled = chatWorker.IsBusy;
            gameNotifyGroupBox.Enabled = serverComboBox.Text == "Minigames" && chatWorker.IsBusy;
            if(chatWorker.IsBusy) {
                if(serverComboBox.Text == "Minigames") {
                    apiWorker.CancelAsync();
                }
                chatWorker.CancelAsync();
            } else {
                if(serverComboBox.Text == "Minigames") {
                    apiWorker.RunWorkerAsync();
                }
                chatWorker.RunWorkerAsync(path);
            }
            await Task.Delay(2000);
            starterButton.Enabled = true;
        }
    }
}
