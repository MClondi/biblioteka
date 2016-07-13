namespace Biblioteka.Forms
{
    partial class ReportForm
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
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReport = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.comboBoxReports, "Dane dla ktorych zostanie wygenerowany raport");
            this.comboBoxReports.Location = new System.Drawing.Point(13, 13);
            this.comboBoxReports.Name = "comboBoxReports";
            this.helpProvider1.SetShowHelp(this.comboBoxReports, true);
            this.comboBoxReports.Size = new System.Drawing.Size(408, 21);
            this.comboBoxReports.TabIndex = 0;
            this.comboBoxReports.SelectedIndexChanged += new System.EventHandler(this.comboBoxReports_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podgląd";
            // 
            // textBoxReport
            // 
            this.helpProvider1.SetHelpString(this.textBoxReport, "Tekst wygenerowanego raportu");
            this.textBoxReport.Location = new System.Drawing.Point(13, 80);
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBoxReport, true);
            this.textBoxReport.Size = new System.Drawing.Size(408, 443);
            this.textBoxReport.TabIndex = 2;
            this.textBoxReport.Text = "";
            this.textBoxReport.WordWrap = false;
            // 
            // buttonSave
            // 
            this.helpProvider1.SetHelpString(this.buttonSave, "Przycisk pozwalajacy zapisac do pliku wygenerowany raport");
            this.buttonSave.Location = new System.Drawing.Point(330, 529);
            this.buttonSave.Name = "buttonSave";
            this.helpProvider1.SetShowHelp(this.buttonSave, true);
            this.buttonSave.Size = new System.Drawing.Size(91, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Zapisz do pliku";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker1
            // 
            this.helpProvider1.SetHelpString(this.dateTimePicker1, "Data poczatkowa - data od ktorej ma zostac wygenerowany raport");
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.helpProvider1.SetShowHelp(this.dateTimePicker1, true);
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.helpProvider1.SetHelpString(this.dateTimePicker2, "Data koncowa danych do raportu");
            this.dateTimePicker2.Location = new System.Drawing.Point(246, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.helpProvider1.SetShowHelp(this.dateTimePicker2, true);
            this.dateTimePicker2.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "do";
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(145, 529);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(179, 23);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 564);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxReports);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBoxReport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
    }
}