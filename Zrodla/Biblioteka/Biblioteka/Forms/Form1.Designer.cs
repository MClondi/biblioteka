namespace Biblioteka
{
    partial class Form1
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
            this.dbExampleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dbExampleListBox
            // 
            this.dbExampleListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbExampleListBox.FormattingEnabled = true;
            this.dbExampleListBox.ItemHeight = 16;
            this.dbExampleListBox.Location = new System.Drawing.Point(0, 0);
            this.dbExampleListBox.Name = "dbExampleListBox";
            this.dbExampleListBox.Size = new System.Drawing.Size(282, 253);
            this.dbExampleListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.dbExampleListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dbExampleListBox;
    }
}

