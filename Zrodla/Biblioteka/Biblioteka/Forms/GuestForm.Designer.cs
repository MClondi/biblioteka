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
            this.lstViewBooksAndUsers = new System.Windows.Forms.ListView();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.btnCheckIfResourceAvailable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewBooksAndUsers
            // 
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 12);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(471, 272);
            this.lstViewBooksAndUsers.TabIndex = 8;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(12, 290);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 9;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            // 
            // btnCheckIfResourceAvailable
            // 
            this.btnCheckIfResourceAvailable.Location = new System.Drawing.Point(130, 290);
            this.btnCheckIfResourceAvailable.Name = "btnCheckIfResourceAvailable";
            this.btnCheckIfResourceAvailable.Size = new System.Drawing.Size(136, 23);
            this.btnCheckIfResourceAvailable.TabIndex = 11;
            this.btnCheckIfResourceAvailable.Text = "Sprawdź dostępność";
            this.btnCheckIfResourceAvailable.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 331);
            this.Controls.Add(this.btnCheckIfResourceAvailable);
            this.Controls.Add(this.btnSearchResource);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Name = "UserForm";
            this.Text = "Panel użytkownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewBooksAndUsers;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.Button btnCheckIfResourceAvailable;
    }
}