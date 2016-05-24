namespace Biblioteka.Forms
{
    partial class LibrarianForm
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
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.btnEditResource = new System.Windows.Forms.Button();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnBorrowResource = new System.Windows.Forms.Button();
            this.btnReserveResource = new System.Windows.Forms.Button();
            this.btnNoteReturn = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(366, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Wyloguj się";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lstViewBooksAndUsers
            // 
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 51);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(466, 186);
            this.lstViewBooksAndUsers.TabIndex = 7;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(12, 261);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(112, 23);
            this.btnSearchUser.TabIndex = 8;
            this.btnSearchUser.Text = "Szukaj użytkownika";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(130, 261);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 9;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(131, 23);
            this.btnUpdateDatabase.TabIndex = 10;
            this.btnUpdateDatabase.Text = "Zaktualizuj bazę danych";
            this.btnUpdateDatabase.UseVisualStyleBackColor = true;
            // 
            // btnEditResource
            // 
            this.btnEditResource.Location = new System.Drawing.Point(248, 261);
            this.btnEditResource.Name = "btnEditResource";
            this.btnEditResource.Size = new System.Drawing.Size(112, 23);
            this.btnEditResource.TabIndex = 11;
            this.btnEditResource.Text = "Edytuj zasób";
            this.btnEditResource.UseVisualStyleBackColor = true;
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.Location = new System.Drawing.Point(366, 261);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteResource.TabIndex = 12;
            this.btnDeleteResource.Text = "Usuń zasób";
            this.btnDeleteResource.UseVisualStyleBackColor = true;
            // 
            // btnBorrowResource
            // 
            this.btnBorrowResource.Location = new System.Drawing.Point(12, 290);
            this.btnBorrowResource.Name = "btnBorrowResource";
            this.btnBorrowResource.Size = new System.Drawing.Size(112, 23);
            this.btnBorrowResource.TabIndex = 13;
            this.btnBorrowResource.Text = "Wypożycz zasób";
            this.btnBorrowResource.UseVisualStyleBackColor = true;
            // 
            // btnReserveResource
            // 
            this.btnReserveResource.Location = new System.Drawing.Point(130, 290);
            this.btnReserveResource.Name = "btnReserveResource";
            this.btnReserveResource.Size = new System.Drawing.Size(112, 23);
            this.btnReserveResource.TabIndex = 14;
            this.btnReserveResource.Text = "Zarezerwuj zasób";
            this.btnReserveResource.UseVisualStyleBackColor = true;
            // 
            // btnNoteReturn
            // 
            this.btnNoteReturn.Location = new System.Drawing.Point(248, 290);
            this.btnNoteReturn.Name = "btnNoteReturn";
            this.btnNoteReturn.Size = new System.Drawing.Size(112, 23);
            this.btnNoteReturn.TabIndex = 15;
            this.btnNoteReturn.Text = "Zaksięguj zwrot";
            this.btnNoteReturn.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(366, 290);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(112, 23);
            this.btnCancelReservation.TabIndex = 16;
            this.btnCancelReservation.Text = "Usuń rezerwację";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 331);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.btnNoteReturn);
            this.Controls.Add(this.btnReserveResource);
            this.Controls.Add(this.btnBorrowResource);
            this.Controls.Add(this.btnDeleteResource);
            this.Controls.Add(this.btnEditResource);
            this.Controls.Add(this.btnUpdateDatabase);
            this.Controls.Add(this.btnSearchResource);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Controls.Add(this.btnLogout);
            this.Name = "LibrarianForm";
            this.Text = "Panel bibliotekarza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView lstViewBooksAndUsers;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.Button btnEditResource;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.Button btnBorrowResource;
        private System.Windows.Forms.Button btnReserveResource;
        private System.Windows.Forms.Button btnNoteReturn;
        private System.Windows.Forms.Button btnCancelReservation;
    }
}