namespace Biblioteka.Forms
{
    partial class AdminForm
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lstViewAllUsers = new System.Windows.Forms.ListView();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.helpProvider1.SetHelpString(this.btnAddUser, "Press this button to add new user");
            this.btnAddUser.Location = new System.Drawing.Point(12, 261);
            this.btnAddUser.Name = "btnAddUser";
            this.helpProvider1.SetShowHelp(this.btnAddUser, true);
            this.btnAddUser.Size = new System.Drawing.Size(112, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Dodaj użytkownika";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lstViewAllUsers
            // 
            this.helpProvider1.SetHelpString(this.lstViewAllUsers, "This is screen where users are displayed");
            this.lstViewAllUsers.Location = new System.Drawing.Point(12, 51);
            this.lstViewAllUsers.Name = "lstViewAllUsers";
            this.helpProvider1.SetShowHelp(this.lstViewAllUsers, true);
            this.lstViewAllUsers.Size = new System.Drawing.Size(466, 186);
            this.lstViewAllUsers.TabIndex = 1;
            this.lstViewAllUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewAllUsers.View = System.Windows.Forms.View.List;
            // 
            // btnEditUser
            // 
            this.helpProvider1.SetHelpString(this.btnEditUser, "Press this button on chosen user to edit him");
            this.btnEditUser.Location = new System.Drawing.Point(130, 261);
            this.btnEditUser.Name = "btnEditUser";
            this.helpProvider1.SetShowHelp(this.btnEditUser, true);
            this.btnEditUser.Size = new System.Drawing.Size(112, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Edytuj użytkownika";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.helpProvider1.SetHelpString(this.btnDeleteUser, "Press this button on chosen user to remove him");
            this.btnDeleteUser.Location = new System.Drawing.Point(248, 261);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.helpProvider1.SetShowHelp(this.btnDeleteUser, true);
            this.btnDeleteUser.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Usuń użytkownika";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnSearchUser
            // 
            this.helpProvider1.SetHelpString(this.btnSearchUser, "Press this button to search user");
            this.btnSearchUser.Location = new System.Drawing.Point(366, 261);
            this.btnSearchUser.Name = "btnSearchUser";
            this.helpProvider1.SetShowHelp(this.btnSearchUser, true);
            this.btnSearchUser.Size = new System.Drawing.Size(112, 23);
            this.btnSearchUser.TabIndex = 4;
            this.btnSearchUser.Text = "Szukaj użytkownika";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnLogout
            // 
            this.helpProvider1.SetHelpString(this.btnLogout, "Press this button to log out from the system");
            this.btnLogout.Location = new System.Drawing.Point(366, 12);
            this.btnLogout.Name = "btnLogout";
            this.helpProvider1.SetShowHelp(this.btnLogout, true);
            this.btnLogout.Size = new System.Drawing.Size(112, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Wyloguj się";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "This button allows to turn on/off help");
            this.helpButton.Location = new System.Drawing.Point(205, 12);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(155, 23);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 313);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.lstViewAllUsers);
            this.Controls.Add(this.btnAddUser);
            this.Name = "AdminForm";
            this.Text = "Panel administratora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListView lstViewAllUsers;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
    }
}