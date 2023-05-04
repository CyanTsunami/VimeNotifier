using System;
using System.Windows.Forms;

namespace VimeNotifier {
    public partial class Form2: Form {
        private int currentHashCode;
        private string currentState;
        public Form2(string aliases) {
            InitializeComponent();
            currentHashCode = aliases.GetHashCode();
            if(aliases != string.Empty) {
                foreach(string item in aliases.Split(';')) {
                    AliasesComboBox.Items.Add(item);
                }
                AliasesComboBox.SelectedIndex = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e) {
            currentState = "AddRadioButton";
        }

        private void ПомощьToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Псевдонимы необходимы, если в чате вас называют не по нику, " +
                "а как-то иначе. И да, регистр не важен...", 
                "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RadioButton_Click(object sender, EventArgs e) {
            RadioButton button = (RadioButton)sender;
            currentState = button.Name;
            switch(currentState) {
                case "AddRadioButton":
                    AliasTextBox.Enabled = true;
                    ExecuteButton.Enabled = true;
                    AliasLabel.Text = "Добавить:";
                    break;
                case "EditRadioButton":
                    AliasTextBox.Enabled = AliasesComboBox.Items.Count != 0;
                    ExecuteButton.Enabled = AliasesComboBox.Items.Count != 0;
                    AliasLabel.Text = "Изменить на:";
                    break;
                case "DeleteRadioButton":
                    AliasTextBox.Enabled = false;
                    ExecuteButton.Enabled = AliasesComboBox.Items.Count != 0;
                    AliasLabel.Text = "Удалить:";
                    break;
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e) {
            switch(currentState) {
                case "AddRadioButton":
                    if(AliasesComboBox.Items.Contains(AliasTextBox.Text.ToLower())) {
                        MessageBox.Show("Псевдоним уже существует", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    AliasesComboBox.Items.Add(AliasTextBox.Text.ToLower());
                    AliasesComboBox.SelectedIndex = AliasesComboBox.Items.Count - 1;
                    break;
                case "EditRadioButton":
                    if(AliasesComboBox.Items.Contains(AliasTextBox.Text.ToLower())) {
                        MessageBox.Show("Псевдоним уже существует", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    AliasesComboBox.Items[AliasesComboBox.SelectedIndex] = AliasTextBox.Text;
                    break;
                case "DeleteRadioButton":
                    AliasesComboBox.Items.RemoveAt(AliasesComboBox.SelectedIndex);
                    ExecuteButton.Enabled = AliasesComboBox.Items.Count != 0;
                    if(AliasesComboBox.Items.Count != 0) {
                        AliasesComboBox.SelectedIndex = AliasesComboBox.Items.Count - 1;
                    }
                    break;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            currentHashCode = String.Join(";", Form1.ComboBoxToList(AliasesComboBox)).GetHashCode();
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) {
            int hash = String.Join(";", Form1.ComboBoxToList(AliasesComboBox)).GetHashCode();
            if(hash != currentHashCode) {
                DialogResult code = MessageBox.Show("У вас есть несохранённые изменения. " +
                    "Уверены, что хотите выйти?", "Внимание",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(code != DialogResult.OK) {
                    e.Cancel = true;
                }
            }
        }
    }
}
