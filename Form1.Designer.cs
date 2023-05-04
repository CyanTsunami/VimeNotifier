namespace VimeNotifier {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameNotifyGroupBox = new System.Windows.Forms.GroupBox();
            this.GameActivateCheckBox = new System.Windows.Forms.CheckBox();
            this.setDefaultGameSoundButton = new System.Windows.Forms.Button();
            this.setOwnGameSoundButton = new System.Windows.Forms.Button();
            this.gameSoundLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.chatNotifyGroupBox = new System.Windows.Forms.GroupBox();
            this.ChatActivateCheckBox = new System.Windows.Forms.CheckBox();
            this.setDefaultChatSoundButton = new System.Windows.Forms.Button();
            this.setOwnChatSoundButton = new System.Windows.Forms.Button();
            this.chatSoundLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChatFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.DMFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.starterButton = new System.Windows.Forms.Button();
            this.gameNotifyGroupBox.SuspendLayout();
            this.chatNotifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameNotifyGroupBox
            // 
            this.gameNotifyGroupBox.Controls.Add(this.GameActivateCheckBox);
            this.gameNotifyGroupBox.Controls.Add(this.setDefaultGameSoundButton);
            this.gameNotifyGroupBox.Controls.Add(this.setOwnGameSoundButton);
            this.gameNotifyGroupBox.Controls.Add(this.gameSoundLabel);
            this.gameNotifyGroupBox.Controls.Add(this.label6);
            this.gameNotifyGroupBox.Location = new System.Drawing.Point(14, 191);
            this.gameNotifyGroupBox.Name = "gameNotifyGroupBox";
            this.gameNotifyGroupBox.Size = new System.Drawing.Size(304, 80);
            this.gameNotifyGroupBox.TabIndex = 3;
            this.gameNotifyGroupBox.TabStop = false;
            this.gameNotifyGroupBox.Text = "Игровые уведомления";
            // 
            // GameActivateCheckBox
            // 
            this.GameActivateCheckBox.AutoSize = true;
            this.GameActivateCheckBox.Checked = true;
            this.GameActivateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GameActivateCheckBox.Location = new System.Drawing.Point(201, 19);
            this.GameActivateCheckBox.Name = "GameActivateCheckBox";
            this.GameActivateCheckBox.Size = new System.Drawing.Size(97, 17);
            this.GameActivateCheckBox.TabIndex = 8;
            this.GameActivateCheckBox.Text = "Активировать";
            this.GameActivateCheckBox.UseVisualStyleBackColor = true;
            this.GameActivateCheckBox.CheckedChanged += new System.EventHandler(this.FlagCheckBox_CheckedChanged);
            // 
            // setDefaultGameSoundButton
            // 
            this.setDefaultGameSoundButton.Location = new System.Drawing.Point(165, 42);
            this.setDefaultGameSoundButton.Name = "setDefaultGameSoundButton";
            this.setDefaultGameSoundButton.Size = new System.Drawing.Size(133, 23);
            this.setDefaultGameSoundButton.TabIndex = 7;
            this.setDefaultGameSoundButton.Text = "Сбросить";
            this.setDefaultGameSoundButton.UseVisualStyleBackColor = true;
            this.setDefaultGameSoundButton.Click += new System.EventHandler(this.SetDefaultGameSoundButton_Click);
            // 
            // setOwnGameSoundButton
            // 
            this.setOwnGameSoundButton.Location = new System.Drawing.Point(9, 42);
            this.setOwnGameSoundButton.Name = "setOwnGameSoundButton";
            this.setOwnGameSoundButton.Size = new System.Drawing.Size(133, 23);
            this.setOwnGameSoundButton.TabIndex = 6;
            this.setOwnGameSoundButton.Text = "Выбрать свой звук...";
            this.setOwnGameSoundButton.UseVisualStyleBackColor = true;
            this.setOwnGameSoundButton.Click += new System.EventHandler(this.SetOwnGameSoundButton_Click);
            // 
            // gameSoundLabel
            // 
            this.gameSoundLabel.Location = new System.Drawing.Point(39, 20);
            this.gameSoundLabel.Name = "gameSoundLabel";
            this.gameSoundLabel.Size = new System.Drawing.Size(156, 13);
            this.gameSoundLabel.TabIndex = 5;
            this.gameSoundLabel.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Звук:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сервер:";
            // 
            // serverComboBox
            // 
            this.serverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Items.AddRange(new object[] {
            "Minigames",
            "CivCraft",
            "Vime",
            "Explore",
            "Discover",
            "Flair",
            "Empire",
            "Wurst",
            "Hoden"});
            this.serverComboBox.Location = new System.Drawing.Point(72, 10);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(155, 21);
            this.serverComboBox.TabIndex = 0;
            this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.ServerComboBox_SelectedIndexChanged);
            // 
            // chatNotifyGroupBox
            // 
            this.chatNotifyGroupBox.Controls.Add(this.ChatActivateCheckBox);
            this.chatNotifyGroupBox.Controls.Add(this.setDefaultChatSoundButton);
            this.chatNotifyGroupBox.Controls.Add(this.setOwnChatSoundButton);
            this.chatNotifyGroupBox.Controls.Add(this.chatSoundLabel);
            this.chatNotifyGroupBox.Controls.Add(this.label3);
            this.chatNotifyGroupBox.Controls.Add(this.ChatFlagCheckBox);
            this.chatNotifyGroupBox.Controls.Add(this.DMFlagCheckBox);
            this.chatNotifyGroupBox.Location = new System.Drawing.Point(14, 65);
            this.chatNotifyGroupBox.Name = "chatNotifyGroupBox";
            this.chatNotifyGroupBox.Size = new System.Drawing.Size(304, 120);
            this.chatNotifyGroupBox.TabIndex = 2;
            this.chatNotifyGroupBox.TabStop = false;
            this.chatNotifyGroupBox.Text = "Уведомления в чате";
            // 
            // ChatActivateCheckBox
            // 
            this.ChatActivateCheckBox.AutoSize = true;
            this.ChatActivateCheckBox.Checked = true;
            this.ChatActivateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChatActivateCheckBox.Location = new System.Drawing.Point(201, 22);
            this.ChatActivateCheckBox.Name = "ChatActivateCheckBox";
            this.ChatActivateCheckBox.Size = new System.Drawing.Size(97, 17);
            this.ChatActivateCheckBox.TabIndex = 9;
            this.ChatActivateCheckBox.Text = "Активировать";
            this.ChatActivateCheckBox.UseVisualStyleBackColor = true;
            this.ChatActivateCheckBox.CheckedChanged += new System.EventHandler(this.FlagCheckBox_CheckedChanged);
            // 
            // setDefaultChatSoundButton
            // 
            this.setDefaultChatSoundButton.Location = new System.Drawing.Point(165, 69);
            this.setDefaultChatSoundButton.Name = "setDefaultChatSoundButton";
            this.setDefaultChatSoundButton.Size = new System.Drawing.Size(133, 23);
            this.setDefaultChatSoundButton.TabIndex = 5;
            this.setDefaultChatSoundButton.Text = "Сбросить";
            this.setDefaultChatSoundButton.UseVisualStyleBackColor = true;
            this.setDefaultChatSoundButton.Click += new System.EventHandler(this.SetDefaultChatSoundButton_Click);
            // 
            // setOwnChatSoundButton
            // 
            this.setOwnChatSoundButton.Location = new System.Drawing.Point(9, 69);
            this.setOwnChatSoundButton.Name = "setOwnChatSoundButton";
            this.setOwnChatSoundButton.Size = new System.Drawing.Size(133, 23);
            this.setOwnChatSoundButton.TabIndex = 4;
            this.setOwnChatSoundButton.Text = "Выбрать свой звук...";
            this.setOwnChatSoundButton.UseVisualStyleBackColor = true;
            this.setOwnChatSoundButton.Click += new System.EventHandler(this.SetOwnSoundButton_Click);
            // 
            // chatSoundLabel
            // 
            this.chatSoundLabel.Location = new System.Drawing.Point(39, 23);
            this.chatSoundLabel.Name = "chatSoundLabel";
            this.chatSoundLabel.Size = new System.Drawing.Size(156, 13);
            this.chatSoundLabel.TabIndex = 3;
            this.chatSoundLabel.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Звук:";
            // 
            // ChatFlagCheckBox
            // 
            this.ChatFlagCheckBox.AutoSize = true;
            this.ChatFlagCheckBox.Location = new System.Drawing.Point(174, 46);
            this.ChatFlagCheckBox.Name = "ChatFlagCheckBox";
            this.ChatFlagCheckBox.Size = new System.Drawing.Size(124, 17);
            this.ChatFlagCheckBox.TabIndex = 3;
            this.ChatFlagCheckBox.Text = "Упоминание в чате";
            this.ChatFlagCheckBox.UseVisualStyleBackColor = true;
            this.ChatFlagCheckBox.CheckedChanged += new System.EventHandler(this.FlagCheckBox_CheckedChanged);
            // 
            // DMFlagCheckBox
            // 
            this.DMFlagCheckBox.AutoSize = true;
            this.DMFlagCheckBox.Location = new System.Drawing.Point(9, 46);
            this.DMFlagCheckBox.Name = "DMFlagCheckBox";
            this.DMFlagCheckBox.Size = new System.Drawing.Size(125, 17);
            this.DMFlagCheckBox.TabIndex = 2;
            this.DMFlagCheckBox.Text = "Личные сообщения";
            this.DMFlagCheckBox.UseVisualStyleBackColor = true;
            this.DMFlagCheckBox.CheckedChanged += new System.EventHandler(this.FlagCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Игрок:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(73, 42);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(16, 13);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "...";
            // 
            // starterButton
            // 
            this.starterButton.Location = new System.Drawing.Point(233, 9);
            this.starterButton.Name = "starterButton";
            this.starterButton.Size = new System.Drawing.Size(85, 23);
            this.starterButton.TabIndex = 1;
            this.starterButton.Text = "Включить";
            this.starterButton.UseVisualStyleBackColor = true;
            this.starterButton.Click += new System.EventHandler(this.StarterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 282);
            this.Controls.Add(this.starterButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chatNotifyGroupBox);
            this.Controls.Add(this.serverComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameNotifyGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VimeNotifier";
            this.gameNotifyGroupBox.ResumeLayout(false);
            this.gameNotifyGroupBox.PerformLayout();
            this.chatNotifyGroupBox.ResumeLayout(false);
            this.chatNotifyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gameNotifyGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serverComboBox;
        private System.Windows.Forms.GroupBox chatNotifyGroupBox;
        private System.Windows.Forms.CheckBox ChatFlagCheckBox;
        private System.Windows.Forms.CheckBox DMFlagCheckBox;
        private System.Windows.Forms.Label chatSoundLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setOwnChatSoundButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button setDefaultChatSoundButton;
        private System.Windows.Forms.Button starterButton;
        private System.Windows.Forms.Button setDefaultGameSoundButton;
        private System.Windows.Forms.Button setOwnGameSoundButton;
        private System.Windows.Forms.Label gameSoundLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox GameActivateCheckBox;
        private System.Windows.Forms.CheckBox ChatActivateCheckBox;
    }
}

