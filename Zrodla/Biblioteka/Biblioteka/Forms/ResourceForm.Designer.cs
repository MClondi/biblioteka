namespace Biblioteka.Forms
{
    partial class ResourceForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.helpProvider1.SetHelpString(this.buttonExit, "Przycisk pozwalajacy anulowac wprowadzone dane i/lub powrocic do poprzedniego ekr" +
        "anu");
            this.buttonExit.Location = new System.Drawing.Point(177, 106);
            this.buttonExit.Name = "buttonExit";
            this.helpProvider1.SetShowHelp(this.buttonExit, true);
            this.buttonExit.Size = new System.Drawing.Size(148, 23);
            this.buttonExit.TabIndex = 49;
            this.buttonExit.Text = "Anuluj";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.helpProvider1.SetHelpString(this.buttonSave, "Przycisk pozwalajacy zapisac wprowadzone dane w bazie");
            this.buttonSave.Location = new System.Drawing.Point(12, 106);
            this.buttonSave.Name = "buttonSave";
            this.helpProvider1.SetShowHelp(this.buttonSave, true);
            this.buttonSave.Size = new System.Drawing.Size(136, 23);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ilość";
            // 
            // txtBoxAmount
            // 
            this.helpProvider1.SetHelpString(this.txtBoxAmount, "Pole ktore pozwala okreslic ilosc zasobu w biliotece");
            this.txtBoxAmount.Location = new System.Drawing.Point(102, 70);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.helpProvider1.SetShowHelp(this.txtBoxAmount, true);
            this.txtBoxAmount.Size = new System.Drawing.Size(223, 20);
            this.txtBoxAmount.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Kategoria";
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Enabled = false;
            this.helpProvider1.SetHelpString(this.txtBoxCategory, "Pole ktore pozwala wprowadzic kategorie zasobu");
            this.txtBoxCategory.Location = new System.Drawing.Point(102, 44);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.helpProvider1.SetShowHelp(this.txtBoxCategory, true);
            this.txtBoxCategory.Size = new System.Drawing.Size(223, 20);
            this.txtBoxCategory.TabIndex = 50;
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy na wlaczenie/wylaczenie pomocy");
            this.helpButton.Location = new System.Drawing.Point(134, 12);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(191, 23);
            this.helpButton.TabIndex = 52;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // ResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 141);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCategory);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAmount);
            this.Name = "ResourceForm";
            this.Text = "Zasób";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
    }
}