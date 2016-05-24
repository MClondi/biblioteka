namespace Biblioteka.Forms
{
    partial class GuestForm
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
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.btnCheckIfResourceAvailable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstViewBooksAndUsers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(12, 290);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 9;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // btnCheckIfResourceAvailable
            // 
            this.btnCheckIfResourceAvailable.Location = new System.Drawing.Point(184, 290);
            this.btnCheckIfResourceAvailable.Name = "btnCheckIfResourceAvailable";
            this.btnCheckIfResourceAvailable.Size = new System.Drawing.Size(136, 23);
            this.btnCheckIfResourceAvailable.TabIndex = 11;
            this.btnCheckIfResourceAvailable.Text = "Sprawdź dostępność";
            this.btnCheckIfResourceAvailable.UseVisualStyleBackColor = true;
            this.btnCheckIfResourceAvailable.Click += new System.EventHandler(this.btnCheckIfResourceAvailable_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Wyjdź";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstViewBooksAndUsers
            // 
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 12);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(471, 272);
            this.lstViewBooksAndUsers.TabIndex = 8;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 331);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckIfResourceAvailable);
            this.Controls.Add(this.btnSearchResource);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Name = "GuestForm";
            this.Text = "Panel użytkownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.Button btnCheckIfResourceAvailable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lstViewBooksAndUsers;
    }
}