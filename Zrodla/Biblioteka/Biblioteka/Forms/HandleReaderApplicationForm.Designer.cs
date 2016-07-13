namespace Biblioteka.Forms
{
    partial class HandleReaderApplicationForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oldPostal = new System.Windows.Forms.TextBox();
            this.oldCity = new System.Windows.Forms.TextBox();
            this.oldApartament = new System.Windows.Forms.TextBox();
            this.oldStreetNumber = new System.Windows.Forms.TextBox();
            this.oldStreet = new System.Windows.Forms.TextBox();
            this.oldPhone = new System.Windows.Forms.TextBox();
            this.oldSurname = new System.Windows.Forms.TextBox();
            this.oldName = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.newPostal = new System.Windows.Forms.TextBox();
            this.newCity = new System.Windows.Forms.TextBox();
            this.newApartament = new System.Windows.Forms.TextBox();
            this.newStreetNumber = new System.Windows.Forms.TextBox();
            this.newStreet = new System.Windows.Forms.TextBox();
            this.newPhone = new System.Windows.Forms.TextBox();
            this.newSurname = new System.Windows.Forms.TextBox();
            this.newName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.helpProvider1.SetHelpString(this.btnCancel, "Przycisk pozwalajacy anulowac edycje wniosku i/lub powrocic do poprzedniego ekran" +
        "u");
            this.btnCancel.Location = new System.Drawing.Point(319, 282);
            this.btnCancel.Name = "btnCancel";
            this.helpProvider1.SetShowHelp(this.btnCancel, true);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReject
            // 
            this.helpProvider1.SetHelpString(this.btnReject, "Przycisk pozwalajacy odrzucic wniosek edycji dancyh");
            this.btnReject.Location = new System.Drawing.Point(197, 282);
            this.btnReject.Name = "btnReject";
            this.helpProvider1.SetShowHelp(this.btnReject, true);
            this.btnReject.Size = new System.Drawing.Size(116, 23);
            this.btnReject.TabIndex = 98;
            this.btnReject.Text = "Odrzuć wniosek";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "Kod pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Miasto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "Nr mieszkania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Nr domu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Ulica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Tel.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Imie";
            // 
            // oldPostal
            // 
            this.oldPostal.Enabled = false;
            this.helpProvider1.SetHelpString(this.oldPostal, "Pole przedstawiajace kod pocztowy wystepujace aktualnie w bazie");
            this.oldPostal.Location = new System.Drawing.Point(132, 247);
            this.oldPostal.Name = "oldPostal";
            this.helpProvider1.SetShowHelp(this.oldPostal, true);
            this.oldPostal.Size = new System.Drawing.Size(110, 20);
            this.oldPostal.TabIndex = 89;
            // 
            // oldCity
            // 
            this.oldCity.Enabled = false;
            this.helpProvider1.SetHelpString(this.oldCity, "Pole przedstawiajace miasto wystepujace aktualnie w bazie");
            this.oldCity.Location = new System.Drawing.Point(132, 221);
            this.oldCity.Name = "oldCity";
            this.helpProvider1.SetShowHelp(this.oldCity, true);
            this.oldCity.Size = new System.Drawing.Size(110, 20);
            this.oldCity.TabIndex = 88;
            this.oldCity.TextChanged += new System.EventHandler(this.oldCity_TextChanged);
            // 
            // oldApartament
            // 
            this.oldApartament.Enabled = false;
            this.helpProvider1.SetHelpString(this.oldApartament, "Pole przedstawiajace numer mieszkania wystepujace aktualnie w bazie");
            this.oldApartament.Location = new System.Drawing.Point(132, 195);
            this.oldApartament.Name = "oldApartament";
            this.helpProvider1.SetShowHelp(this.oldApartament, true);
            this.oldApartament.Size = new System.Drawing.Size(110, 20);
            this.oldApartament.TabIndex = 87;
            // 
            // oldStreetNumber
            // 
            this.oldStreetNumber.Enabled = false;
            this.helpProvider1.SetHelpString(this.oldStreetNumber, "Pole przedstawiajace nr domu wystepujace aktualnie w bazie");
            this.oldStreetNumber.Location = new System.Drawing.Point(132, 169);
            this.oldStreetNumber.Name = "oldStreetNumber";
            this.helpProvider1.SetShowHelp(this.oldStreetNumber, true);
            this.oldStreetNumber.Size = new System.Drawing.Size(110, 20);
            this.oldStreetNumber.TabIndex = 86;
            // 
            // oldStreet
            // 
            this.oldStreet.Enabled = false;
            this.oldStreet.Location = new System.Drawing.Point(132, 143);
            this.oldStreet.Name = "oldStreet";
            this.oldStreet.Size = new System.Drawing.Size(110, 20);
            this.oldStreet.TabIndex = 85;
            // 
            // oldPhone
            // 
            this.oldPhone.Enabled = false;
            this.helpProvider1.SetHelpString(this.oldPhone, "Pole przedstawiajace numer telefonu wystepujace aktualnie w bazie");
            this.oldPhone.Location = new System.Drawing.Point(132, 117);
            this.oldPhone.Name = "oldPhone";
            this.helpProvider1.SetShowHelp(this.oldPhone, true);
            this.oldPhone.Size = new System.Drawing.Size(110, 20);
            this.oldPhone.TabIndex = 84;
            // 
            // oldSurname
            // 
            this.oldSurname.Enabled = false;
            this.helpProvider1.SetHelpString(this.oldSurname, "Pole przedstawiajace nazwisko wystepujace aktualnie w bazie");
            this.oldSurname.Location = new System.Drawing.Point(132, 91);
            this.oldSurname.Name = "oldSurname";
            this.helpProvider1.SetShowHelp(this.oldSurname, true);
            this.oldSurname.Size = new System.Drawing.Size(110, 20);
            this.oldSurname.TabIndex = 83;
            // 
            // oldName
            // 
            this.oldName.Enabled = false;
            this.helpProvider1.SetHelpString(this.oldName, "Pole przedstawiajace imie wystepujace aktualnie w bazie");
            this.oldName.Location = new System.Drawing.Point(132, 65);
            this.oldName.Name = "oldName";
            this.helpProvider1.SetShowHelp(this.oldName, true);
            this.oldName.Size = new System.Drawing.Size(110, 20);
            this.oldName.TabIndex = 82;
            // 
            // btnAccept
            // 
            this.helpProvider1.SetHelpString(this.btnAccept, "Przycisk pozwalajacy zaakceptowac wystawiony wniosek");
            this.btnAccept.Location = new System.Drawing.Point(75, 282);
            this.btnAccept.Name = "btnAccept";
            this.helpProvider1.SetShowHelp(this.btnAccept, true);
            this.btnAccept.Size = new System.Drawing.Size(116, 23);
            this.btnAccept.TabIndex = 100;
            this.btnAccept.Text = "Zaakceptuj wniosek";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // newPostal
            // 
            this.newPostal.Enabled = false;
            this.helpProvider1.SetHelpString(this.newPostal, "Pole przedstawiajace kod pocztowy znajdujade sie w wniosku");
            this.newPostal.Location = new System.Drawing.Point(273, 247);
            this.newPostal.Name = "newPostal";
            this.helpProvider1.SetShowHelp(this.newPostal, true);
            this.newPostal.Size = new System.Drawing.Size(110, 20);
            this.newPostal.TabIndex = 108;
            // 
            // newCity
            // 
            this.newCity.Enabled = false;
            this.helpProvider1.SetHelpString(this.newCity, "Pole przedstawiajace miasto znajdujade sie w wniosku");
            this.newCity.Location = new System.Drawing.Point(273, 221);
            this.newCity.Name = "newCity";
            this.helpProvider1.SetShowHelp(this.newCity, true);
            this.newCity.Size = new System.Drawing.Size(110, 20);
            this.newCity.TabIndex = 107;
            // 
            // newApartament
            // 
            this.newApartament.Enabled = false;
            this.helpProvider1.SetHelpString(this.newApartament, "Pole przedstawiajace numer mieszkania znajdujade sie w wniosku");
            this.newApartament.Location = new System.Drawing.Point(273, 195);
            this.newApartament.Name = "newApartament";
            this.helpProvider1.SetShowHelp(this.newApartament, true);
            this.newApartament.Size = new System.Drawing.Size(110, 20);
            this.newApartament.TabIndex = 106;
            // 
            // newStreetNumber
            // 
            this.newStreetNumber.Enabled = false;
            this.helpProvider1.SetHelpString(this.newStreetNumber, "Pole przedstawiajace numer domu znajdujade sie w wniosku");
            this.newStreetNumber.Location = new System.Drawing.Point(273, 169);
            this.newStreetNumber.Name = "newStreetNumber";
            this.helpProvider1.SetShowHelp(this.newStreetNumber, true);
            this.newStreetNumber.Size = new System.Drawing.Size(110, 20);
            this.newStreetNumber.TabIndex = 105;
            // 
            // newStreet
            // 
            this.newStreet.Enabled = false;
            this.helpProvider1.SetHelpString(this.newStreet, "Pole przedstawiajace ulice znajdujade sie w wniosku");
            this.newStreet.Location = new System.Drawing.Point(273, 143);
            this.newStreet.Name = "newStreet";
            this.helpProvider1.SetShowHelp(this.newStreet, true);
            this.newStreet.Size = new System.Drawing.Size(110, 20);
            this.newStreet.TabIndex = 104;
            // 
            // newPhone
            // 
            this.newPhone.Enabled = false;
            this.helpProvider1.SetHelpString(this.newPhone, "Pole przedstawiajace numer telefonu znajdujade sie w wniosku");
            this.newPhone.Location = new System.Drawing.Point(273, 117);
            this.newPhone.Name = "newPhone";
            this.helpProvider1.SetShowHelp(this.newPhone, true);
            this.newPhone.Size = new System.Drawing.Size(110, 20);
            this.newPhone.TabIndex = 103;
            // 
            // newSurname
            // 
            this.newSurname.Enabled = false;
            this.helpProvider1.SetHelpString(this.newSurname, "Pole przedstawiajace nazwisko znajdujade sie w wniosku");
            this.newSurname.Location = new System.Drawing.Point(273, 91);
            this.newSurname.Name = "newSurname";
            this.helpProvider1.SetShowHelp(this.newSurname, true);
            this.newSurname.Size = new System.Drawing.Size(110, 20);
            this.newSurname.TabIndex = 102;
            // 
            // newName
            // 
            this.newName.Enabled = false;
            this.helpProvider1.SetHelpString(this.newName, "Pole przedstawiajace imie znajdujade sie w wniosku");
            this.newName.Location = new System.Drawing.Point(273, 65);
            this.newName.Name = "newName";
            this.helpProvider1.SetShowHelp(this.newName, true);
            this.newName.Size = new System.Drawing.Size(110, 20);
            this.newName.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Aktualne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "We wniosku";
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(197, 12);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(186, 23);
            this.helpButton.TabIndex = 111;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // HandleReaderApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 315);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPostal);
            this.Controls.Add(this.newCity);
            this.Controls.Add(this.newApartament);
            this.Controls.Add(this.newStreetNumber);
            this.Controls.Add(this.newStreet);
            this.Controls.Add(this.newPhone);
            this.Controls.Add(this.newSurname);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oldPostal);
            this.Controls.Add(this.oldCity);
            this.Controls.Add(this.oldApartament);
            this.Controls.Add(this.oldStreetNumber);
            this.Controls.Add(this.oldStreet);
            this.Controls.Add(this.oldPhone);
            this.Controls.Add(this.oldSurname);
            this.Controls.Add(this.oldName);
            this.Name = "HandleReaderApplicationForm";
            this.Text = "Obsłuż wniosek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldPostal;
        private System.Windows.Forms.TextBox oldCity;
        private System.Windows.Forms.TextBox oldApartament;
        private System.Windows.Forms.TextBox oldStreetNumber;
        private System.Windows.Forms.TextBox oldStreet;
        private System.Windows.Forms.TextBox oldPhone;
        private System.Windows.Forms.TextBox oldSurname;
        private System.Windows.Forms.TextBox oldName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox newPostal;
        private System.Windows.Forms.TextBox newCity;
        private System.Windows.Forms.TextBox newApartament;
        private System.Windows.Forms.TextBox newStreetNumber;
        private System.Windows.Forms.TextBox newStreet;
        private System.Windows.Forms.TextBox newPhone;
        private System.Windows.Forms.TextBox newSurname;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
    }
}