﻿namespace Biblioteka.Forms
{
    partial class ReservationForm
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.helpProvider1.SetHelpString(this.buttonExit, "Przycisk pozwalajacy anulowac wprowadzone zmiany i/lub przeniesc do poprzedniego " +
        "ekranu");
            this.buttonExit.Location = new System.Drawing.Point(178, 106);
            this.buttonExit.Name = "buttonExit";
            this.helpProvider1.SetShowHelp(this.buttonExit, true);
            this.buttonExit.Size = new System.Drawing.Size(148, 23);
            this.buttonExit.TabIndex = 54;
            this.buttonExit.Text = "Anuluj";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.helpProvider1.SetHelpString(this.buttonSave, "Przycisk pozwalajacy zapisac wprowadzone zmiany");
            this.buttonSave.Location = new System.Drawing.Point(16, 106);
            this.buttonSave.Name = "buttonSave";
            this.helpProvider1.SetShowHelp(this.buttonSave, true);
            this.buttonSave.Size = new System.Drawing.Size(136, 23);
            this.buttonSave.TabIndex = 53;
            this.buttonSave.Text = "Zarezerwuj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // datePicker
            // 
            this.helpProvider1.SetHelpString(this.datePicker, "Pole pozwalajace wybrac termin koncowy rezerwacji");
            this.datePicker.Location = new System.Drawing.Point(112, 65);
            this.datePicker.Name = "datePicker";
            this.helpProvider1.SetShowHelp(this.datePicker, true);
            this.datePicker.Size = new System.Drawing.Size(223, 20);
            this.datePicker.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Termin końca";
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(112, 13);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(211, 23);
            this.helpButton.TabIndex = 55;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 141);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "Rezerwacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
    }
}