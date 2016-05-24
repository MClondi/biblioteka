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
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(366, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Wyloguj się";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstViewBooksAndUsers
            // 
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 51);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(466, 186);
            this.lstViewBooksAndUsers.TabIndex = 8;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(12, 261);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 9;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            // 
            // btnReserveResource
            // 
            this.btnReserveResource.Location = new System.Drawing.Point(12, 290);
            this.btnReserveResource.Name = "btnReserveResource";
            this.btnReserveResource.Size = new System.Drawing.Size(112, 23);
            this.btnReserveResource.TabIndex = 10;
            this.btnReserveResource.Text = "Zarezerwuj zasób";
            this.btnReserveResource.UseVisualStyleBackColor = true;
            // 
            // btnCheckIfResourceAvailable
            // 
            this.btnCheckIfResourceAvailable.Location = new System.Drawing.Point(248, 261);
            this.btnCheckIfResourceAvailable.Name = "btnCheckIfResourceAvailable";
            this.btnCheckIfResourceAvailable.Size = new System.Drawing.Size(107, 52);
            this.btnCheckIfResourceAvailable.TabIndex = 11;
            this.btnCheckIfResourceAvailable.Text = "Sprawdź dostępność";
            this.btnCheckIfResourceAvailable.UseVisualStyleBackColor = true;
            this.btnCheckIfResourceAvailable.Click += new System.EventHandler(this.btnCheckIfResourceAvailable_Click);
            // 
            // btnUpdateUserAccount
            // 
            this.btnUpdateUserAccount.Location = new System.Drawing.Point(366, 261);
            this.btnUpdateUserAccount.Name = "btnUpdateUserAccount";
            this.btnUpdateUserAccount.Size = new System.Drawing.Size(112, 52);
            this.btnUpdateUserAccount.TabIndex = 12;
            this.btnUpdateUserAccount.Text = "Zgłoś wniosek o aktualizację karty klienta";
            this.btnUpdateUserAccount.UseVisualStyleBackColor = true;
            // 
            // btnCheckBorrowedPositions
            // 
            this.btnCheckBorrowedPositions.Location = new System.Drawing.Point(130, 261);
            this.btnCheckBorrowedPositions.Name = "btnCheckBorrowedPositions";
            this.btnCheckBorrowedPositions.Size = new System.Drawing.Size(112, 54);
            this.btnCheckBorrowedPositions.TabIndex = 13;
            this.btnCheckBorrowedPositions.Text = "Przeglądaj wypożyczone zasoby";
            this.btnCheckBorrowedPositions.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 331);
            this.Controls.Add(this.btnCheckBorrowedPositions);
            this.Controls.Add(this.btnUpdateUserAccount);
            this.Controls.Add(this.btnCheckIfResourceAvailable);
            this.Controls.Add(this.btnReserveResource);
            this.Controls.Add(this.btnSearchResource);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Controls.Add(this.btnLogout);
            this.Name = "UserForm";
            this.Text = "Panel użytkownika";
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
    }
}