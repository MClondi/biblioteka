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
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnSearchResource
            // 
            this.helpProvider1.SetHelpString(this.btnSearchResource, "Przycisk pozwalajacy wyszukiwac zasoby w bazie biblioteki");
            this.btnSearchResource.Location = new System.Drawing.Point(12, 317);
            this.btnSearchResource.Name = "btnSearchResource";
            this.helpProvider1.SetShowHelp(this.btnSearchResource, true);
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 9;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // btnCheckIfResourceAvailable
            // 
            this.helpProvider1.SetHelpString(this.btnCheckIfResourceAvailable, "Przycisk pozwalajacy sprawdzic dostępnosc zasobu w bibliotece ");
            this.btnCheckIfResourceAvailable.Location = new System.Drawing.Point(183, 317);
            this.btnCheckIfResourceAvailable.Name = "btnCheckIfResourceAvailable";
            this.helpProvider1.SetShowHelp(this.btnCheckIfResourceAvailable, true);
            this.btnCheckIfResourceAvailable.Size = new System.Drawing.Size(136, 23);
            this.btnCheckIfResourceAvailable.TabIndex = 11;
            this.btnCheckIfResourceAvailable.Text = "Sprawdź dostępność";
            this.btnCheckIfResourceAvailable.UseVisualStyleBackColor = true;
            this.btnCheckIfResourceAvailable.Click += new System.EventHandler(this.btnCheckIfResourceAvailable_Click);
            // 
            // btnExit
            // 
            this.helpProvider1.SetHelpString(this.btnExit, "Przycisk pozwolacy wyjsc z ekranu goscia");
            this.btnExit.Location = new System.Drawing.Point(390, 317);
            this.btnExit.Name = "btnExit";
            this.helpProvider1.SetShowHelp(this.btnExit, true);
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Wyjdź";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstViewBooksAndUsers
            // 
            this.helpProvider1.SetHelpString(this.lstViewBooksAndUsers, "Lista zasobow na stanie biblioteki");
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 39);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.helpProvider1.SetShowHelp(this.lstViewBooksAndUsers, true);
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(471, 272);
            this.lstViewBooksAndUsers.TabIndex = 8;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewBooksAndUsers.View = System.Windows.Forms.View.List;
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy na wlaczenie/wylaczenie pomocy");
            this.helpButton.Location = new System.Drawing.Point(294, 10);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(189, 23);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 352);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckIfResourceAvailable);
            this.Controls.Add(this.btnSearchResource);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Name = "GuestForm";
            this.Text = "Panel gościa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.Button btnCheckIfResourceAvailable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lstViewBooksAndUsers;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}