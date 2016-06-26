namespace Biblioteka.Forms
{
    partial class PositionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeSpinner = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxApt = new System.Windows.Forms.TextBox();
            this.textBoxStrNum = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.helpProvider.SetHelpString(this.buttonExit, "Anuluj wprowadzone dane i cofnij sie do poprzedniego ekranu");
            this.buttonExit.Location = new System.Drawing.Point(180, 345);
            this.buttonExit.Name = "buttonExit";
            this.helpProvider.SetShowHelp(this.buttonExit, true);
            this.buttonExit.Size = new System.Drawing.Size(148, 23);
            this.buttonExit.TabIndex = 89;
            this.buttonExit.Text = "Anuluj";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.helpProvider.SetHelpString(this.buttonSave, "Wyszukaj uzytkownika w bazie danych na podstawie wprowadzonych informacji");
            this.buttonSave.Location = new System.Drawing.Point(18, 345);
            this.buttonSave.Name = "buttonSave";
            this.helpProvider.SetShowHelp(this.buttonSave, true);
            this.buttonSave.Size = new System.Drawing.Size(136, 23);
            this.buttonSave.TabIndex = 88;
            this.buttonSave.Text = "Szukaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 313);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Kod pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 287);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Miasto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 261);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "Nr mieszkania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Nr domu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Ulica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Tel.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Imie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Login";
            // 
            // typeSpinner
            // 
            this.typeSpinner.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.typeSpinner, "Tutaj wprowadz typ uzytkownika");
            this.typeSpinner.Location = new System.Drawing.Point(105, 45);
            this.typeSpinner.Name = "typeSpinner";
            this.helpProvider.SetShowHelp(this.typeSpinner, true);
            this.typeSpinner.Size = new System.Drawing.Size(223, 21);
            this.typeSpinner.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Typ";
            // 
            // textBoxPostal
            // 
            this.helpProvider.SetHelpString(this.textBoxPostal, "Tutaj wprowadz kod pocztowy miasta zameldowania uzytkownika");
            this.textBoxPostal.Location = new System.Drawing.Point(105, 306);
            this.textBoxPostal.Name = "textBoxPostal";
            this.helpProvider.SetShowHelp(this.textBoxPostal, true);
            this.textBoxPostal.Size = new System.Drawing.Size(223, 20);
            this.textBoxPostal.TabIndex = 75;
            // 
            // textBoxCity
            // 
            this.helpProvider.SetHelpString(this.textBoxCity, "Tutaj wprowadz miasto zamieszkania uzytkownika");
            this.textBoxCity.Location = new System.Drawing.Point(105, 280);
            this.textBoxCity.Name = "textBoxCity";
            this.helpProvider.SetShowHelp(this.textBoxCity, true);
            this.textBoxCity.Size = new System.Drawing.Size(223, 20);
            this.textBoxCity.TabIndex = 74;
            // 
            // textBoxApt
            // 
            this.helpProvider.SetHelpString(this.textBoxApt, "Tutaj wprowadz numer mieszkania uzytkownika");
            this.textBoxApt.Location = new System.Drawing.Point(105, 254);
            this.textBoxApt.Name = "textBoxApt";
            this.helpProvider.SetShowHelp(this.textBoxApt, true);
            this.textBoxApt.Size = new System.Drawing.Size(223, 20);
            this.textBoxApt.TabIndex = 73;
            // 
            // textBoxStrNum
            // 
            this.helpProvider.SetHelpString(this.textBoxStrNum, "Tutaj wprowadz numer domu uzytkownika");
            this.textBoxStrNum.Location = new System.Drawing.Point(105, 228);
            this.textBoxStrNum.Name = "textBoxStrNum";
            this.helpProvider.SetShowHelp(this.textBoxStrNum, true);
            this.textBoxStrNum.Size = new System.Drawing.Size(223, 20);
            this.textBoxStrNum.TabIndex = 72;
            // 
            // textBoxStreet
            // 
            this.helpProvider.SetHelpString(this.textBoxStreet, "Tutaj wprowadz nazwe ulicy uzytkownika");
            this.textBoxStreet.Location = new System.Drawing.Point(105, 202);
            this.textBoxStreet.Name = "textBoxStreet";
            this.helpProvider.SetShowHelp(this.textBoxStreet, true);
            this.textBoxStreet.Size = new System.Drawing.Size(223, 20);
            this.textBoxStreet.TabIndex = 71;
            // 
            // textBoxTel
            // 
            this.helpProvider.SetHelpString(this.textBoxTel, "Tutaj wprowadz numer telefonu uzytkownika");
            this.textBoxTel.Location = new System.Drawing.Point(105, 176);
            this.textBoxTel.Name = "textBoxTel";
            this.helpProvider.SetShowHelp(this.textBoxTel, true);
            this.textBoxTel.Size = new System.Drawing.Size(223, 20);
            this.textBoxTel.TabIndex = 70;
            // 
            // textBoxSurname
            // 
            this.helpProvider.SetHelpString(this.textBoxSurname, "Tutaj wprowadz nazwisko uzytkownika");
            this.textBoxSurname.Location = new System.Drawing.Point(105, 150);
            this.textBoxSurname.Name = "textBoxSurname";
            this.helpProvider.SetShowHelp(this.textBoxSurname, true);
            this.textBoxSurname.Size = new System.Drawing.Size(223, 20);
            this.textBoxSurname.TabIndex = 69;
            // 
            // textBoxName
            // 
            this.helpProvider.SetHelpString(this.textBoxName, "Tutaj wprowadz imie uzytkownika");
            this.textBoxName.Location = new System.Drawing.Point(105, 124);
            this.textBoxName.Name = "textBoxName";
            this.helpProvider.SetShowHelp(this.textBoxName, true);
            this.textBoxName.Size = new System.Drawing.Size(223, 20);
            this.textBoxName.TabIndex = 68;
            // 
            // textBoxMail
            // 
            this.helpProvider.SetHelpString(this.textBoxMail, "Tutaj wprowadz adres email uzytkownika");
            this.textBoxMail.Location = new System.Drawing.Point(105, 98);
            this.textBoxMail.Name = "textBoxMail";
            this.helpProvider.SetShowHelp(this.textBoxMail, true);
            this.textBoxMail.Size = new System.Drawing.Size(223, 20);
            this.textBoxMail.TabIndex = 67;
            // 
            // textBoxLogin
            // 
            this.helpProvider.SetHelpString(this.textBoxLogin, "Tutaj wprowadz login uzytkownika");
            this.textBoxLogin.Location = new System.Drawing.Point(105, 72);
            this.textBoxLogin.Name = "textBoxLogin";
            this.helpProvider.SetShowHelp(this.textBoxLogin, true);
            this.textBoxLogin.Size = new System.Drawing.Size(223, 20);
            this.textBoxLogin.TabIndex = 66;
            // 
            // helpButton
            // 
            this.helpProvider.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(196, 12);
            this.helpButton.Name = "helpButton";
            this.helpProvider.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(132, 23);
            this.helpButton.TabIndex = 90;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeSpinner);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxPostal);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxApt);
            this.Controls.Add(this.textBoxStrNum);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "PositionForm";
            this.Text = "Pozycja";
            this.Load += new System.EventHandler(this.PositionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeSpinner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxApt;
        private System.Windows.Forms.TextBox textBoxStrNum;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.HelpProvider helpProvider;

    }
}