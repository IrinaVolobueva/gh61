namespace PR_6._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подтвердитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambulanceRadioButton = new System.Windows.Forms.RadioButton();
            this.medicalExaminationRadioButton = new System.Windows.Forms.RadioButton();
            this.medicineRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(409, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуйте, заполните, пожалуйста, \r\nнашу форму!";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(595, 256);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(266, 36);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(595, 318);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(266, 36);
            this.nametextBox.TabIndex = 2;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(595, 385);
            this.patronymicTextBox.Multiline = true;
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(266, 36);
            this.patronymicTextBox.TabIndex = 2;
            this.patronymicTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(595, 457);
            this.ageTextBox.Multiline = true;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(266, 36);
            this.ageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(463, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(405, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(404, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(409, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Возвраст:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подтвердитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // подтвердитьToolStripMenuItem
            // 
            this.подтвердитьToolStripMenuItem.Name = "подтвердитьToolStripMenuItem";
            this.подтвердитьToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.подтвердитьToolStripMenuItem.Text = "Подтвердить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ambulanceRadioButton
            // 
            this.ambulanceRadioButton.AutoSize = true;
            this.ambulanceRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ambulanceRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.ambulanceRadioButton.Location = new System.Drawing.Point(412, 512);
            this.ambulanceRadioButton.Name = "ambulanceRadioButton";
            this.ambulanceRadioButton.Size = new System.Drawing.Size(208, 41);
            this.ambulanceRadioButton.TabIndex = 9;
            this.ambulanceRadioButton.TabStop = true;
            this.ambulanceRadioButton.Text = "скорая помощь";
            this.ambulanceRadioButton.UseVisualStyleBackColor = false;
            // 
            // medicalExaminationRadioButton
            // 
            this.medicalExaminationRadioButton.AutoSize = true;
            this.medicalExaminationRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.medicalExaminationRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.medicalExaminationRadioButton.Location = new System.Drawing.Point(411, 606);
            this.medicalExaminationRadioButton.Name = "medicalExaminationRadioButton";
            this.medicalExaminationRadioButton.Size = new System.Drawing.Size(164, 41);
            this.medicalExaminationRadioButton.TabIndex = 10;
            this.medicalExaminationRadioButton.TabStop = true;
            this.medicalExaminationRadioButton.Text = "медосмотр";
            this.medicalExaminationRadioButton.UseVisualStyleBackColor = false;
            // 
            // medicineRadioButton
            // 
            this.medicineRadioButton.AutoSize = true;
            this.medicineRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.medicineRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.medicineRadioButton.Location = new System.Drawing.Point(412, 559);
            this.medicineRadioButton.Name = "medicineRadioButton";
            this.medicineRadioButton.Size = new System.Drawing.Size(259, 41);
            this.medicineRadioButton.TabIndex = 11;
            this.medicineRadioButton.TabStop = true;
            this.medicineRadioButton.Text = "получение лекарств";
            this.medicineRadioButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.White;
            this.okButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.okButton.Location = new System.Drawing.Point(713, 635);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(143, 48);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Готово";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(588, 646);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Подпись:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::PR_6._1.Properties.Resources.планшет;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 824);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.medicineRadioButton);
            this.Controls.Add(this.medicalExaminationRadioButton);
            this.Controls.Add(this.ambulanceRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ручки-Ножки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подтвердитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.RadioButton ambulanceRadioButton;
        private System.Windows.Forms.RadioButton medicalExaminationRadioButton;
        private System.Windows.Forms.RadioButton medicineRadioButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label6;
    }
}

