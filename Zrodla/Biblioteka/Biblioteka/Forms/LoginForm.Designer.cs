﻿namespace Biblioteka.Forms
{
    partial class LoginForm
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
            this.helloMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEnterAsGuest = new System.Windows.Forms.Button();
            this.loginMessage = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloMessage
            // 
            this.helloMessage.AutoSize = true;
            this.helloMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helloMessage.Location = new System.Drawing.Point(78, 31);
            this.helloMessage.Name = "helloMessage";
            this.helloMessage.Size = new System.Drawing.Size(114, 17);
            this.helloMessage.TabIndex = 0;
            this.helloMessage.Text = "Witaj w systemie!";
            // 
            // btnLogin
            // 
            this.helpProvider1.SetHelpString(this.btnLogin, "Przycisk pozwalajacy na zalogowanie sie do systemu przy uzyciu wprowadzonych wyze" +
        "j  danych");
            this.btnLogin.Location = new System.Drawing.Point(168, 214);
            this.btnLogin.Name = "btnLogin";
            this.helpProvider1.SetShowHelp(this.btnLogin, true);
            this.btnLogin.Size = new System.Drawing.Size(83, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProvider1.SetHelpString(this.txtBxUsername, "Tutaj wprowadz login, ktory wybrales jako login Twojego konta");
            this.txtBxUsername.Location = new System.Drawing.Point(128, 144);
            this.txtBxUsername.Name = "txtBxUsername";
            this.helpProvider1.SetShowHelp(this.txtBxUsername, true);
            this.txtBxUsername.Size = new System.Drawing.Size(123, 21);
            this.txtBxUsername.TabIndex = 2;
            this.txtBxUsername.TextChanged += new System.EventHandler(this.txtBxUsername_TextChanged);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProvider1.SetHelpString(this.txtBxPassword, "Tutaj wprowadz haslo ktore ustawiles podczas rejestracji konta");
            this.txtBxPassword.Location = new System.Drawing.Point(128, 183);
            this.txtBxPassword.Name = "txtBxPassword";
            this.helpProvider1.SetShowHelp(this.txtBxPassword, true);
            this.txtBxPassword.Size = new System.Drawing.Size(123, 21);
            this.txtBxPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(8, 144);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 15);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Nazwa użytkownika";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(78, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Hasło";
            // 
            // btnEnterAsGuest
            // 
            this.helpProvider1.SetHelpString(this.btnEnterAsGuest, "Po wcisnieciu tego przycisku zostaniesz przeniesiony do okna bibliotecznego jako " +
        "gosc, bedziesz mial mozliwosc przegladania zasobow biblioteki");
            this.btnEnterAsGuest.Location = new System.Drawing.Point(81, 61);
            this.btnEnterAsGuest.Name = "btnEnterAsGuest";
            this.helpProvider1.SetShowHelp(this.btnEnterAsGuest, true);
            this.btnEnterAsGuest.Size = new System.Drawing.Size(106, 23);
            this.btnEnterAsGuest.TabIndex = 6;
            this.btnEnterAsGuest.Text = "Wejdź jako gość";
            this.btnEnterAsGuest.UseVisualStyleBackColor = true;
            this.btnEnterAsGuest.Click += new System.EventHandler(this.btnEnterAsGuest_Click);
            // 
            // loginMessage
            // 
            this.loginMessage.AutoSize = true;
            this.loginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginMessage.Location = new System.Drawing.Point(94, 107);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.Size = new System.Drawing.Size(76, 17);
            this.loginMessage.TabIndex = 7;
            this.loginMessage.Text = "Logowanie";
            // 
            // btnRegister
            // 
            this.helpProvider1.SetHelpString(this.btnRegister, "Przycisk pozwalajacy na zlozenie nowego konta");
            this.btnRegister.Location = new System.Drawing.Point(145, 243);
            this.btnRegister.Name = "btnRegister";
            this.helpProvider1.SetShowHelp(this.btnRegister, true);
            this.btnRegister.Size = new System.Drawing.Size(106, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Rejestracja";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(115, 5);
            this.helpButton.Name = "helpButton";
            this.helpButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(152, 23);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 275);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.loginMessage);
            this.Controls.Add(this.btnEnterAsGuest);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.helloMessage);
            this.Name = "LoginForm";
            this.Text = "System obsługi biblioteki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloMessage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEnterAsGuest;
        private System.Windows.Forms.Label loginMessage;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
    }
}