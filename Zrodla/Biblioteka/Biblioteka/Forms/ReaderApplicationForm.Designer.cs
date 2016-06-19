namespace Biblioteka.Forms
{
    partial class ReaderApplicationForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxApt = new System.Windows.Forms.TextBox();
            this.textBoxStrNum = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Kod pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Miasto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Nr mieszkania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Nr domu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Ulica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Tel.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Imie";
            // 
            // textBoxPostal
            // 
            this.helpProvider1.SetHelpString(this.textBoxPostal, "W tym polu podaj kod pocztowy, który zostanie przypisany do karty");
            this.textBoxPostal.Location = new System.Drawing.Point(102, 219);
            this.textBoxPostal.Name = "textBoxPostal";
            this.helpProvider1.SetShowHelp(this.textBoxPostal, true);
            this.textBoxPostal.Size = new System.Drawing.Size(223, 20);
            this.textBoxPostal.TabIndex = 71;
            // 
            // textBoxCity
            // 
            this.helpProvider1.SetHelpString(this.textBoxCity, "W tym polu podaj nazwę miasta, który zostanie przypisany do karty");
            this.textBoxCity.Location = new System.Drawing.Point(102, 193);
            this.textBoxCity.Name = "textBoxCity";
            this.helpProvider1.SetShowHelp(this.textBoxCity, true);
            this.textBoxCity.Size = new System.Drawing.Size(223, 20);
            this.textBoxCity.TabIndex = 70;
            // 
            // textBoxApt
            // 
            this.helpProvider1.SetHelpString(this.textBoxApt, "W tym polu podaj numer mieszkania, który zostanie przypisany do karty");
            this.textBoxApt.Location = new System.Drawing.Point(102, 167);
            this.textBoxApt.Name = "textBoxApt";
            this.helpProvider1.SetShowHelp(this.textBoxApt, true);
            this.textBoxApt.Size = new System.Drawing.Size(223, 20);
            this.textBoxApt.TabIndex = 69;
            // 
            // textBoxStrNum
            // 
            this.helpProvider1.SetHelpString(this.textBoxStrNum, "W tym polu podaj numer domu, który zostanie przypisany do karty");
            this.textBoxStrNum.Location = new System.Drawing.Point(102, 141);
            this.textBoxStrNum.Name = "textBoxStrNum";
            this.helpProvider1.SetShowHelp(this.textBoxStrNum, true);
            this.textBoxStrNum.Size = new System.Drawing.Size(223, 20);
            this.textBoxStrNum.TabIndex = 68;
            // 
            // textBoxStreet
            // 
            this.helpProvider1.SetHelpString(this.textBoxStreet, "W tym polu podaj nazwę ulicy, który zostanie przypisany do karty");
            this.textBoxStreet.Location = new System.Drawing.Point(102, 115);
            this.textBoxStreet.Name = "textBoxStreet";
            this.helpProvider1.SetShowHelp(this.textBoxStreet, true);
            this.textBoxStreet.Size = new System.Drawing.Size(223, 20);
            this.textBoxStreet.TabIndex = 67;
            // 
            // textBoxTel
            // 
            this.helpProvider1.SetHelpString(this.textBoxTel, "W tym polu podaj numer telefonu, który zostanie przypisany do karty");
            this.textBoxTel.Location = new System.Drawing.Point(102, 89);
            this.textBoxTel.Name = "textBoxTel";
            this.helpProvider1.SetShowHelp(this.textBoxTel, true);
            this.textBoxTel.Size = new System.Drawing.Size(223, 20);
            this.textBoxTel.TabIndex = 66;
            // 
            // textBoxSurname
            // 
            this.helpProvider1.SetHelpString(this.textBoxSurname, "W tym polu wprowadź Twoje nazwisko, nazwisko to zostanie przypisane do karty");
            this.textBoxSurname.Location = new System.Drawing.Point(102, 63);
            this.textBoxSurname.Name = "textBoxSurname";
            this.helpProvider1.SetShowHelp(this.textBoxSurname, true);
            this.textBoxSurname.Size = new System.Drawing.Size(223, 20);
            this.textBoxSurname.TabIndex = 65;
            // 
            // textBoxName
            // 
            this.helpProvider1.SetHelpString(this.textBoxName, "W tym polu wprowadź Twoje imię, imię to zostanie przypisane do karty");
            this.textBoxName.Location = new System.Drawing.Point(102, 37);
            this.textBoxName.Name = "textBoxName";
            this.helpProvider1.SetShowHelp(this.textBoxName, true);
            this.textBoxName.Size = new System.Drawing.Size(223, 20);
            this.textBoxName.TabIndex = 64;
            // 
            // send
            // 
            this.helpProvider1.SetHelpString(this.send, "Wciśnij ten przycisk aby wysłać zgłoszenie założenia konta");
            this.send.Location = new System.Drawing.Point(128, 257);
            this.send.Name = "send";
            this.helpProvider1.SetShowHelp(this.send, true);
            this.send.Size = new System.Drawing.Size(116, 23);
            this.send.TabIndex = 80;
            this.send.Text = "Wyślij zgłoszenie";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // cancel
            // 
            this.helpProvider1.SetHelpString(this.cancel, "Wciśnij ten przycisk aby anulować wprowadzone dane i/lub powrócić do poprzedniego" +
        " okna");
            this.cancel.Location = new System.Drawing.Point(250, 257);
            this.cancel.Name = "cancel";
            this.helpProvider1.SetShowHelp(this.cancel, true);
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 81;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalający na włączenie/wyłączenie pomocy");
            this.helpButton.Location = new System.Drawing.Point(103, 8);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(222, 23);
            this.helpButton.TabIndex = 82;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // ReaderApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 292);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPostal);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxApt);
            this.Controls.Add(this.textBoxStrNum);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Name = "ReaderApplicationForm";
            this.Text = "Wniosek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxApt;
        private System.Windows.Forms.TextBox textBoxStrNum;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}