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
            this.btnBorrowResource = new System.Windows.Forms.Button();
            this.btnReserveResource = new System.Windows.Forms.Button();
            this.btnNoteReturn = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.userActionPanel = new System.Windows.Forms.Panel();
            this.usersLabel = new System.Windows.Forms.Label();
            this.resourcesLabel = new System.Windows.Forms.Label();
            this.resourcesPanel = new System.Windows.Forms.Panel();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnEditResource = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnEditPosition = new System.Windows.Forms.Button();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.userActionPanel.SuspendLayout();
            this.resourcesPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(617, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Wyloguj się";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstViewBooksAndUsers
            // 
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 51);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(717, 186);
            this.lstViewBooksAndUsers.TabIndex = 7;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewBooksAndUsers.View = System.Windows.Forms.View.List;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(16, 15);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(112, 23);
            this.btnSearchUser.TabIndex = 8;
            this.btnSearchUser.Text = "Szukaj użytkownika";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(16, 15);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 9;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            // 
            // btnBorrowResource
            // 
            this.btnBorrowResource.Location = new System.Drawing.Point(17, 42);
            this.btnBorrowResource.Name = "btnBorrowResource";
            this.btnBorrowResource.Size = new System.Drawing.Size(112, 23);
            this.btnBorrowResource.TabIndex = 13;
            this.btnBorrowResource.Text = "Wypożycz zasób";
            this.btnBorrowResource.UseVisualStyleBackColor = true;
            // 
            // btnReserveResource
            // 
            this.btnReserveResource.Location = new System.Drawing.Point(17, 13);
            this.btnReserveResource.Name = "btnReserveResource";
            this.btnReserveResource.Size = new System.Drawing.Size(112, 23);
            this.btnReserveResource.TabIndex = 14;
            this.btnReserveResource.Text = "Zarezerwuj zasób";
            this.btnReserveResource.UseVisualStyleBackColor = true;
            // 
            // btnNoteReturn
            // 
            this.btnNoteReturn.Location = new System.Drawing.Point(17, 100);
            this.btnNoteReturn.Name = "btnNoteReturn";
            this.btnNoteReturn.Size = new System.Drawing.Size(112, 23);
            this.btnNoteReturn.TabIndex = 15;
            this.btnNoteReturn.Text = "Zaksięguj zwrot";
            this.btnNoteReturn.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(17, 71);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(112, 23);
            this.btnCancelReservation.TabIndex = 16;
            this.btnCancelReservation.Text = "Usuń rezerwację";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // userActionPanel
            // 
            this.userActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userActionPanel.Controls.Add(this.btnSearchUser);
            this.userActionPanel.Location = new System.Drawing.Point(12, 265);
            this.userActionPanel.Name = "userActionPanel";
            this.userActionPanel.Size = new System.Drawing.Size(143, 58);
            this.userActionPanel.TabIndex = 17;
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(12, 249);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(67, 13);
            this.usersLabel.TabIndex = 18;
            this.usersLabel.Text = "Użytkownicy";
            // 
            // resourcesLabel
            // 
            this.resourcesLabel.AutoSize = true;
            this.resourcesLabel.Location = new System.Drawing.Point(12, 326);
            this.resourcesLabel.Name = "resourcesLabel";
            this.resourcesLabel.Size = new System.Drawing.Size(42, 13);
            this.resourcesLabel.TabIndex = 20;
            this.resourcesLabel.Text = "Zasoby";
            // 
            // resourcesPanel
            // 
            this.resourcesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resourcesPanel.Controls.Add(this.btnSearchResource);
            this.resourcesPanel.Location = new System.Drawing.Point(12, 342);
            this.resourcesPanel.Name = "resourcesPanel";
            this.resourcesPanel.Size = new System.Drawing.Size(143, 58);
            this.resourcesPanel.TabIndex = 19;
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Location = new System.Drawing.Point(166, 249);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(34, 13);
            this.actionsLabel.TabIndex = 22;
            this.actionsLabel.Text = "Akcje";
            // 
            // actionsPanel
            // 
            this.actionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionsPanel.Controls.Add(this.btnReserveResource);
            this.actionsPanel.Controls.Add(this.btnBorrowResource);
            this.actionsPanel.Controls.Add(this.btnCancelReservation);
            this.actionsPanel.Controls.Add(this.btnNoteReturn);
            this.actionsPanel.Location = new System.Drawing.Point(166, 265);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(143, 135);
            this.actionsPanel.TabIndex = 21;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(321, 249);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(69, 13);
            this.databaseLabel.TabIndex = 24;
            this.databaseLabel.Text = "Baza danych";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteResource);
            this.panel1.Controls.Add(this.btnDeleteAuthor);
            this.panel1.Controls.Add(this.btnDeletePosition);
            this.panel1.Controls.Add(this.btnEditResource);
            this.panel1.Controls.Add(this.btnEditAuthor);
            this.panel1.Controls.Add(this.btnEditPosition);
            this.panel1.Controls.Add(this.btnAddResource);
            this.panel1.Controls.Add(this.btnAddAuthor);
            this.panel1.Controls.Add(this.btnAddPosition);
            this.panel1.Location = new System.Drawing.Point(324, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 107);
            this.panel1.TabIndex = 23;
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(17, 13);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(112, 23);
            this.btnAddResource.TabIndex = 14;
            this.btnAddResource.Text = "Dodaj zasób";
            this.btnAddResource.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(17, 42);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(112, 23);
            this.btnAddAuthor.TabIndex = 13;
            this.btnAddAuthor.Text = "Dodaj autora";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(17, 71);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(112, 23);
            this.btnAddPosition.TabIndex = 16;
            this.btnAddPosition.Text = "Dodaj pozycję";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            // 
            // btnEditResource
            // 
            this.btnEditResource.Location = new System.Drawing.Point(145, 13);
            this.btnEditResource.Name = "btnEditResource";
            this.btnEditResource.Size = new System.Drawing.Size(112, 23);
            this.btnEditResource.TabIndex = 18;
            this.btnEditResource.Text = "Edytuj zasób";
            this.btnEditResource.UseVisualStyleBackColor = true;
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Location = new System.Drawing.Point(145, 42);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(112, 23);
            this.btnEditAuthor.TabIndex = 17;
            this.btnEditAuthor.Text = "Edytuj autora";
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Location = new System.Drawing.Point(145, 71);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(112, 23);
            this.btnEditPosition.TabIndex = 19;
            this.btnEditPosition.Text = "Edytuj pozycję";
            this.btnEditPosition.UseVisualStyleBackColor = true;
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.Location = new System.Drawing.Point(272, 13);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteResource.TabIndex = 21;
            this.btnDeleteResource.Text = "Usuń zasób";
            this.btnDeleteResource.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Location = new System.Drawing.Point(272, 42);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteAuthor.TabIndex = 20;
            this.btnDeleteAuthor.Text = "Usuń autora";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Location = new System.Drawing.Point(272, 71);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(112, 23);
            this.btnDeletePosition.TabIndex = 22;
            this.btnDeletePosition.Text = "Usuń pozycję";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 420);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actionsLabel);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.resourcesLabel);
            this.Controls.Add(this.resourcesPanel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.userActionPanel);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Controls.Add(this.btnLogout);
            this.Name = "LibrarianForm";
            this.Text = "Panel bibliotekarza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibrarianForm_FormClosing);
            this.userActionPanel.ResumeLayout(false);
            this.resourcesPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView lstViewBooksAndUsers;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.Button btnBorrowResource;
        private System.Windows.Forms.Button btnReserveResource;
        private System.Windows.Forms.Button btnNoteReturn;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Panel userActionPanel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label resourcesLabel;
        private System.Windows.Forms.Panel resourcesPanel;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Button btnEditResource;
        private System.Windows.Forms.Button btnEditAuthor;
        private System.Windows.Forms.Button btnEditPosition;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddPosition;
    }
}