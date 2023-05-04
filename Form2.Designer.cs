namespace VimeNotifier {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.AliasesComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AliasLabel = new System.Windows.Forms.Label();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.EditRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Псевдонимы:";
            // 
            // AliasesComboBox
            // 
            this.AliasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AliasesComboBox.FormattingEnabled = true;
            this.AliasesComboBox.Location = new System.Drawing.Point(92, 19);
            this.AliasesComboBox.Name = "AliasesComboBox";
            this.AliasesComboBox.Size = new System.Drawing.Size(168, 21);
            this.AliasesComboBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(110, 115);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(77, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.ПомощьToolStripMenuItem_Click);
            // 
            // AliasLabel
            // 
            this.AliasLabel.AutoSize = true;
            this.AliasLabel.Location = new System.Drawing.Point(12, 53);
            this.AliasLabel.Name = "AliasLabel";
            this.AliasLabel.Size = new System.Drawing.Size(60, 13);
            this.AliasLabel.TabIndex = 4;
            this.AliasLabel.Text = "Добавить:";
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.Location = new System.Drawing.Point(92, 50);
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(168, 20);
            this.AliasTextBox.TabIndex = 1;
            // 
            // Button
            // 
            this.Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button.Location = new System.Drawing.Point(193, 115);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 7;
            this.Button.Text = "Отменить";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Checked = true;
            this.AddRadioButton.Location = new System.Drawing.Point(19, 87);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(75, 17);
            this.AddRadioButton.TabIndex = 2;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Добавить";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            this.AddRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // EditRadioButton
            // 
            this.EditRadioButton.AutoSize = true;
            this.EditRadioButton.Location = new System.Drawing.Point(100, 87);
            this.EditRadioButton.Name = "EditRadioButton";
            this.EditRadioButton.Size = new System.Drawing.Size(76, 17);
            this.EditRadioButton.TabIndex = 3;
            this.EditRadioButton.Text = "Изменить";
            this.EditRadioButton.UseVisualStyleBackColor = true;
            this.EditRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Location = new System.Drawing.Point(182, 87);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(68, 17);
            this.DeleteRadioButton.TabIndex = 4;
            this.DeleteRadioButton.Text = "Удалить";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            this.DeleteRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExecuteButton);
            this.groupBox1.Controls.Add(this.Button);
            this.groupBox1.Controls.Add(this.AddRadioButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.DeleteRadioButton);
            this.groupBox1.Controls.Add(this.AliasTextBox);
            this.groupBox1.Controls.Add(this.EditRadioButton);
            this.groupBox1.Controls.Add(this.AliasLabel);
            this.groupBox1.Controls.Add(this.AliasesComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 152);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(6, 115);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(80, 23);
            this.ExecuteButton.TabIndex = 5;
            this.ExecuteButton.Text = "Выполнить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 187);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Псевдонимы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Label AliasLabel;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.Button Button;
        public System.Windows.Forms.ComboBox AliasesComboBox;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.RadioButton EditRadioButton;
        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExecuteButton;
    }
}