namespace Biblioteka.Forms
{
    partial class AddUser
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxStrNum = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxApt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.typeSpinner = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.helpProvider1.SetHelpString(this.textBoxLogin, "Tutaj wprowadz login do swojego konta, loginem bedziesz poslugiwal się w momencie" +
        " logowania");
            this.textBoxLogin.Location = new System.Drawing.Point(102, 59);
            this.textBoxLogin.Name = "textBoxLogin";
            this.helpProvider1.SetShowHelp(this.textBoxLogin, true);
            this.textBoxLogin.Size = new System.Drawing.Size(223, 20);
            this.textBoxLogin.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.helpProvider1.SetHelpString(this.textBoxPassword, "Tutaj wprowadz haslo do konta, haslo bedzie wymagane zawsze podczas logowania");
            this.textBoxPassword.Location = new System.Drawing.Point(102, 85);
            this.textBoxPassword.Name = "textBoxPassword";
            this.helpProvider1.SetShowHelp(this.textBoxPassword, true);
            this.textBoxPassword.Size = new System.Drawing.Size(223, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.helpProvider1.SetHelpString(this.textBoxName, "W tym polu podaje swoje imie");
            this.textBoxName.Location = new System.Drawing.Point(102, 137);
            this.textBoxName.Name = "textBoxName";
            this.helpProvider1.SetShowHelp(this.textBoxName, true);
            this.textBoxName.Size = new System.Drawing.Size(223, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxMail
            // 
            this.helpProvider1.SetHelpString(this.textBoxMail, "W tym polu podaj email z ktorym powiazane bedzie konto, na podany email przyjdzie" +
        " link aktywujacy");
            this.textBoxMail.Location = new System.Drawing.Point(102, 111);
            this.textBoxMail.Name = "textBoxMail";
            this.helpProvider1.SetShowHelp(this.textBoxMail, true);
            this.textBoxMail.Size = new System.Drawing.Size(223, 20);
            this.textBoxMail.TabIndex = 12;
            // 
            // textBoxTel
            // 
            this.helpProvider1.SetHelpString(this.textBoxTel, "W tym polu podaj swoj numer telefonu");
            this.textBoxTel.Location = new System.Drawing.Point(102, 189);
            this.textBoxTel.Name = "textBoxTel";
            this.helpProvider1.SetShowHelp(this.textBoxTel, true);
            this.textBoxTel.Size = new System.Drawing.Size(223, 20);
            this.textBoxTel.TabIndex = 15;
            // 
            // textBoxSurname
            // 
            this.helpProvider1.SetHelpString(this.textBoxSurname, "W tym polu podaj swoje nazwisko");
            this.textBoxSurname.Location = new System.Drawing.Point(102, 163);
            this.textBoxSurname.Name = "textBoxSurname";
            this.helpProvider1.SetShowHelp(this.textBoxSurname, true);
            this.textBoxSurname.Size = new System.Drawing.Size(223, 20);
            this.textBoxSurname.TabIndex = 14;
            // 
            // textBoxStrNum
            // 
            this.helpProvider1.SetHelpString(this.textBoxStrNum, "W tym polu podaj numer domu w ktorym jestes zameldowany");
            this.textBoxStrNum.Location = new System.Drawing.Point(102, 241);
            this.textBoxStrNum.Name = "textBoxStrNum";
            this.helpProvider1.SetShowHelp(this.textBoxStrNum, true);
            this.textBoxStrNum.Size = new System.Drawing.Size(223, 20);
            this.textBoxStrNum.TabIndex = 17;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpProvider1.SetHelpString(this.textBoxStreet, "W tym polu podaj nazwe ulicy na której jesteś zameldowany");
            this.textBoxStreet.Location = new System.Drawing.Point(102, 215);
            this.textBoxStreet.Name = "textBoxStreet";
            this.helpProvider1.SetShowHelp(this.textBoxStreet, true);
            this.textBoxStreet.Size = new System.Drawing.Size(223, 20);
            this.textBoxStreet.TabIndex = 16;
            // 
            // textBoxPostal
            // 
            this.helpProvider1.SetHelpString(this.textBoxPostal, "W tym polu podaj kod pocztowy miasta w ktorym jestes zameldowany");
            this.textBoxPostal.Location = new System.Drawing.Point(102, 319);
            this.textBoxPostal.Name = "textBoxPostal";
            this.helpProvider1.SetShowHelp(this.textBoxPostal, true);
            this.textBoxPostal.Size = new System.Drawing.Size(223, 20);
            this.textBoxPostal.TabIndex = 20;
            // 
            // textBoxCity
            // 
            this.helpProvider1.SetHelpString(this.textBoxCity, "W tym polu podaj miasto w ktorym jestes zameldowany");
            this.textBoxCity.Location = new System.Drawing.Point(102, 293);
            this.textBoxCity.Name = "textBoxCity";
            this.helpProvider1.SetShowHelp(this.textBoxCity, true);
            this.textBoxCity.Size = new System.Drawing.Size(223, 20);
            this.textBoxCity.TabIndex = 19;
            // 
            // textBoxApt
            // 
            this.helpProvider1.SetHelpString(this.textBoxApt, "W tym polu podaj numer mieszkania w ktorym jestes zameldowany");
            this.textBoxApt.Location = new System.Drawing.Point(102, 267);
            this.textBoxApt.Name = "textBoxApt";
            this.helpProvider1.SetShowHelp(this.textBoxApt, true);
            this.textBoxApt.Size = new System.Drawing.Size(223, 20);
            this.textBoxApt.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.helpProvider1.SetHelpString(this.label11, "Type of the account");
            this.label11.Location = new System.Drawing.Point(10, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label11.Name = "label11";
            this.helpProvider1.SetShowHelp(this.label11, true);
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Typ";
            // 
            // typeSpinner
            // 
            this.typeSpinner.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.typeSpinner, "Tutaj wybierz typ konta, typ A - administrator, L - bibliotekarz, U - uzytkownik");
            this.typeSpinner.Location = new System.Drawing.Point(102, 32);
            this.typeSpinner.Name = "typeSpinner";
            this.helpProvider1.SetShowHelp(this.typeSpinner, true);
            this.typeSpinner.Size = new System.Drawing.Size(223, 21);
            this.typeSpinner.TabIndex = 26;
            this.typeSpinner.SelectedIndexChanged += new System.EventHandler(this.typeSpinner_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.helpProvider1.SetHelpString(this.label1, "Login of the account");
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Imie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nr domu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ulica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tel.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Kod pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Miasto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 274);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nr mieszkania";
            // 
            // buttonSave
            // 
            this.helpProvider1.SetHelpString(this.buttonSave, "Nacisnij ten przycisk jezeli chcesz zapisac zmiany");
            this.buttonSave.Location = new System.Drawing.Point(15, 357);
            this.buttonSave.Name = "buttonSave";
            this.helpProvider1.SetShowHelp(this.buttonSave, true);
            this.buttonSave.Size = new System.Drawing.Size(136, 23);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.helpProvider1.SetHelpString(this.buttonExit, "Nacisnij ten przycisk jezeli chcesz anulowac wszystkie wprowadzone zmiany");
            this.buttonExit.Location = new System.Drawing.Point(177, 357);
            this.buttonExit.Name = "buttonExit";
            this.helpProvider1.SetShowHelp(this.buttonExit, true);
            this.buttonExit.Size = new System.Drawing.Size(148, 23);
            this.buttonExit.TabIndex = 39;
            this.buttonExit.Text = "Anuluj";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc opcje pomocy");
            this.helpButton.Location = new System.Drawing.Point(102, 3);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(223, 23);
            this.helpButton.TabIndex = 40;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Login";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 392);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "AddUser";
            this.Text = "Dodaj użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxStrNum;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxApt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox typeSpinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label13;

    }
}