namespace Biblioteka.Forms
{
    partial class UserForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstViewBooksAndUsers = new System.Windows.Forms.ListView();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.btnReserveResource = new System.Windows.Forms.Button();
            this.btnCheckIfResourceAvailable = new System.Windows.Forms.Button();
            this.btnUpdateUserAccount = new System.Windows.Forms.Button();
            this.btnCheckBorrowedPositions = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnShowReservations = new System.Windows.Forms.Button();
            this.btnShowResourceReservations = new System.Windows.Forms.Button();
            this.btnShowApplications = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.helpProvider1.SetHelpString(this.btnLogout, "Po wcisnieciu tego przycisku zostaniesz wylogowany");
            this.btnLogout.Location = new System.Drawing.Point(366, 12);
            this.btnLogout.Name = "btnLogout";
            this.helpProvider1.SetShowHelp(this.btnLogout, true);
            this.btnLogout.Size = new System.Drawing.Size(112, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Wyloguj się";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstViewBooksAndUsers
            // 
            this.helpProvider1.SetHelpString(this.lstViewBooksAndUsers, "Pole na ktory wyswietlane sa wszystkie zasoby biblioteki");
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 51);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.helpProvider1.SetShowHelp(this.lstViewBooksAndUsers, true);
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(466, 186);
            this.lstViewBooksAndUsers.TabIndex = 8;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewBooksAndUsers.View = System.Windows.Forms.View.List;
            // 
            // btnSearchResource
            // 
            this.helpProvider1.SetHelpString(this.btnSearchResource, "Przycisk pozwalajacy na szukanie zasobow bibliotecznych");
            this.btnSearchResource.Location = new System.Drawing.Point(12, 261);
            this.btnSearchResource.Name = "btnSearchResource";
            this.helpProvider1.SetShowHelp(this.btnSearchResource, true);
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 9;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // btnReserveResource
            // 
            this.helpProvider1.SetHelpString(this.btnReserveResource, "Przycisk pozwalajacy na zarezerwowanie zasobu");
            this.btnReserveResource.Location = new System.Drawing.Point(12, 292);
            this.btnReserveResource.Name = "btnReserveResource";
            this.helpProvider1.SetShowHelp(this.btnReserveResource, true);
            this.btnReserveResource.Size = new System.Drawing.Size(112, 23);
            this.btnReserveResource.TabIndex = 10;
            this.btnReserveResource.Text = "Zarezerwuj zasób";
            this.btnReserveResource.UseVisualStyleBackColor = true;
            this.btnReserveResource.Click += new System.EventHandler(this.btnReserveResource_Click);
            // 
            // btnCheckIfResourceAvailable
            // 
            this.helpProvider1.SetHelpString(this.btnCheckIfResourceAvailable, "Przycisk pozwalajacy sprawdzic dostepnosc zasobow");
            this.btnCheckIfResourceAvailable.Location = new System.Drawing.Point(248, 261);
            this.btnCheckIfResourceAvailable.Name = "btnCheckIfResourceAvailable";
            this.helpProvider1.SetShowHelp(this.btnCheckIfResourceAvailable, true);
            this.btnCheckIfResourceAvailable.Size = new System.Drawing.Size(107, 54);
            this.btnCheckIfResourceAvailable.TabIndex = 11;
            this.btnCheckIfResourceAvailable.Text = "Sprawdź dostępność";
            this.btnCheckIfResourceAvailable.UseVisualStyleBackColor = true;
            this.btnCheckIfResourceAvailable.Click += new System.EventHandler(this.btnCheckIfResourceAvailable_Click);
            // 
            // btnUpdateUserAccount
            // 
            this.helpProvider1.SetHelpString(this.btnUpdateUserAccount, "Przycisk pozwalajacy na zgloszenie wniosku o aktualizacje karty klienta bibliotek" +
        "i");
            this.btnUpdateUserAccount.Location = new System.Drawing.Point(361, 261);
            this.btnUpdateUserAccount.Name = "btnUpdateUserAccount";
            this.helpProvider1.SetShowHelp(this.btnUpdateUserAccount, true);
            this.btnUpdateUserAccount.Size = new System.Drawing.Size(112, 54);
            this.btnUpdateUserAccount.TabIndex = 12;
            this.btnUpdateUserAccount.Text = "Zgłoś wniosek o aktualizację karty klienta";
            this.btnUpdateUserAccount.UseVisualStyleBackColor = true;
            this.btnUpdateUserAccount.Click += new System.EventHandler(this.btnUpdateUserAccount_Click);
            // 
            // btnCheckBorrowedPositions
            // 
            this.helpProvider1.SetHelpString(this.btnCheckBorrowedPositions, "Przycisk pozwalajacy przegladac wypozyczone zasoby");
            this.btnCheckBorrowedPositions.Location = new System.Drawing.Point(130, 261);
            this.btnCheckBorrowedPositions.Name = "btnCheckBorrowedPositions";
            this.helpProvider1.SetShowHelp(this.btnCheckBorrowedPositions, true);
            this.btnCheckBorrowedPositions.Size = new System.Drawing.Size(112, 54);
            this.btnCheckBorrowedPositions.TabIndex = 13;
            this.btnCheckBorrowedPositions.Text = "Przeglądaj wypożyczone zasoby";
            this.btnCheckBorrowedPositions.UseVisualStyleBackColor = true;
            this.btnCheckBorrowedPositions.Click += new System.EventHandler(this.btnCheckBorrowedPositions_Click);
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Pozwala wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(190, 12);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(170, 23);
            this.helpButton.TabIndex = 14;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowReservations
            // 
            this.helpProvider1.SetHelpString(this.btnShowReservations, "Przycisk pozwalajacy na zarezerwowanie zasobu");
            this.btnShowReservations.Location = new System.Drawing.Point(130, 321);
            this.btnShowReservations.Name = "btnShowReservations";
            this.helpProvider1.SetShowHelp(this.btnShowReservations, true);
            this.btnShowReservations.Size = new System.Drawing.Size(112, 52);
            this.btnShowReservations.TabIndex = 15;
            this.btnShowReservations.Text = "Przeglądaj moje rezerwacje";
            this.btnShowReservations.UseVisualStyleBackColor = true;
            // 
            // btnShowResourceReservations
            // 
            this.helpProvider1.SetHelpString(this.btnShowResourceReservations, "Przycisk pozwalajacy na zarezerwowanie zasobu");
            this.btnShowResourceReservations.Location = new System.Drawing.Point(248, 321);
            this.btnShowResourceReservations.Name = "btnShowResourceReservations";
            this.helpProvider1.SetShowHelp(this.btnShowResourceReservations, true);
            this.btnShowResourceReservations.Size = new System.Drawing.Size(107, 52);
            this.btnShowResourceReservations.TabIndex = 16;
            this.btnShowResourceReservations.Text = "Przeglądaj rezerwacje zasobu";
            this.btnShowResourceReservations.UseVisualStyleBackColor = true;
            // 
            // btnShowApplications
            // 
            this.helpProvider1.SetHelpString(this.btnShowApplications, "Przycisk pozwalajacy na zgloszenie wniosku o aktualizacje karty klienta bibliotek" +
        "i");
            this.btnShowApplications.Location = new System.Drawing.Point(361, 321);
            this.btnShowApplications.Name = "btnShowApplications";
            this.helpProvider1.SetShowHelp(this.btnShowApplications, true);
            this.btnShowApplications.Size = new System.Drawing.Size(112, 52);
            this.btnShowApplications.TabIndex = 17;
            this.btnShowApplications.Text = "Przeglądaj złożone wnioski";
            this.btnShowApplications.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReservation
            // 
            this.helpProvider1.SetHelpString(this.btnDeleteReservation, "Przycisk pozwalajacy na zarezerwowanie zasobu");
            this.btnDeleteReservation.Location = new System.Drawing.Point(12, 321);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.helpProvider1.SetShowHelp(this.btnDeleteReservation, true);
            this.btnDeleteReservation.Size = new System.Drawing.Size(112, 52);
            this.btnDeleteReservation.TabIndex = 18;
            this.btnDeleteReservation.Text = "Usuń rezerwację";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 390);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnShowApplications);
            this.Controls.Add(this.btnShowResourceReservations);
            this.Controls.Add(this.btnShowReservations);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.btnCheckBorrowedPositions);
            this.Controls.Add(this.btnUpdateUserAccount);
            this.Controls.Add(this.btnCheckIfResourceAvailable);
            this.Controls.Add(this.btnReserveResource);
            this.Controls.Add(this.btnSearchResource);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Controls.Add(this.btnLogout);
            this.Name = "UserForm";
            this.Text = "Panel użytkownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView lstViewBooksAndUsers;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.Button btnReserveResource;
        private System.Windows.Forms.Button btnCheckIfResourceAvailable;
        private System.Windows.Forms.Button btnUpdateUserAccount;
        private System.Windows.Forms.Button btnCheckBorrowedPositions;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnShowReservations;
        private System.Windows.Forms.Button btnShowResourceReservations;
        private System.Windows.Forms.Button btnShowApplications;
        private System.Windows.Forms.Button btnDeleteReservation;
    }
}