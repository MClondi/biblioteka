namespace Biblioteka.Forms
{
    partial class SearchResource
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.comboBoxType, "W tym polu wprowadz typ zasobu ktory chcesz znalezc");
            this.comboBoxType.Location = new System.Drawing.Point(134, 40);
            this.comboBoxType.Name = "comboBoxType";
            this.helpProvider1.SetShowHelp(this.comboBoxType, true);
            this.comboBoxType.Size = new System.Drawing.Size(232, 21);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxTitle
            // 
            this.helpProvider1.SetHelpString(this.textBoxTitle, "W tym polu wprowadz tytul zasobu ktory chcesz znalezc");
            this.textBoxTitle.Location = new System.Drawing.Point(134, 67);
            this.textBoxTitle.Name = "textBoxTitle";
            this.helpProvider1.SetShowHelp(this.textBoxTitle, true);
            this.textBoxTitle.Size = new System.Drawing.Size(232, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxAuthorName
            // 
            this.helpProvider1.SetHelpString(this.textBoxAuthorName, "W tym polu wprowadz imie autora zasobu ktory chcesz znalezc");
            this.textBoxAuthorName.Location = new System.Drawing.Point(134, 93);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.helpProvider1.SetShowHelp(this.textBoxAuthorName, true);
            this.textBoxAuthorName.Size = new System.Drawing.Size(232, 20);
            this.textBoxAuthorName.TabIndex = 2;
            // 
            // textBoxAuthorSurname
            // 
            this.helpProvider1.SetHelpString(this.textBoxAuthorSurname, "W tym polu wprowadz nazwisko autora zasobu ktory chcesz znalezc");
            this.textBoxAuthorSurname.Location = new System.Drawing.Point(134, 119);
            this.textBoxAuthorSurname.Name = "textBoxAuthorSurname";
            this.helpProvider1.SetShowHelp(this.textBoxAuthorSurname, true);
            this.textBoxAuthorSurname.Size = new System.Drawing.Size(232, 20);
            this.textBoxAuthorSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Typ zasobu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imię autora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwisko autora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wydawca / Producent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tytuł";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPublisher
            // 
            this.helpProvider1.SetHelpString(this.textBoxPublisher, "W tym polu wprowadz wydawce/producenta zasobu ktory chcesz znalezc");
            this.textBoxPublisher.Location = new System.Drawing.Point(134, 145);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.helpProvider1.SetShowHelp(this.textBoxPublisher, true);
            this.textBoxPublisher.Size = new System.Drawing.Size(232, 20);
            this.textBoxPublisher.TabIndex = 8;
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Wcisnij ten przycisk aby anulowac wprowadzone dane i/lub cofnac sie do poprzednie" +
        "go okna");
            this.button1.Location = new System.Drawing.Point(291, 181);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.helpProvider1.SetHelpString(this.button2, "Wcisnij ten przycisk aby wyszukac wprowadzone dane w bazie danych");
            this.button2.Location = new System.Drawing.Point(209, 181);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Szukaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajzcy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(164, 4);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(201, 23);
            this.helpButton.TabIndex = 14;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // SearchResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 216);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAuthorSurname);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.comboBoxType);
            this.Name = "SearchResource";
            this.Text = "Szukaj zasobu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.TextBox textBoxAuthorSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}