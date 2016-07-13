namespace Biblioteka.Forms
{
    partial class BookForm
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstViewAddedAuthors = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lstViewSearchAuthor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genreSpinner = new System.Windows.Forms.ComboBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.helpProvider.SetHelpString(this.buttonExit, "Przycisk pozwalajacy na anulowanie zmian pod warunkiem, ze nie zostaly zapisane. " +
        "Anulowanie zmian przeniesie nas do ekranu uzytkownika.");
            this.buttonExit.Location = new System.Drawing.Point(177, 337);
            this.buttonExit.Name = "buttonExit";
            this.helpProvider.SetShowHelp(this.buttonExit, true);
            this.buttonExit.Size = new System.Drawing.Size(148, 23);
            this.buttonExit.TabIndex = 49;
            this.buttonExit.Text = "Anuluj";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.helpProvider.SetHelpString(this.buttonSave, "Przycisk pozwalajacy zapisac wykonane zmiany");
            this.buttonSave.Location = new System.Drawing.Point(15, 337);
            this.buttonSave.Name = "buttonSave";
            this.helpProvider.SetShowHelp(this.buttonSave, true);
            this.buttonSave.Size = new System.Drawing.Size(136, 23);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tytuł";
            // 
            // textBoxTitle
            // 
            this.helpProvider.SetHelpString(this.textBoxTitle, "Wprowadz tutaj tytul ksiazki ktora chcesz wyszukac/dodac");
            this.textBoxTitle.Location = new System.Drawing.Point(102, 37);
            this.textBoxTitle.Name = "textBoxTitle";
            this.helpProvider.SetShowHelp(this.textBoxTitle, true);
            this.textBoxTitle.Size = new System.Drawing.Size(223, 20);
            this.textBoxTitle.TabIndex = 42;
            // 
            // button2
            // 
            this.helpProvider.SetHelpString(this.button2, "Pozwala usunac autora przypisanego do ksiazki");
            this.button2.Location = new System.Drawing.Point(190, 247);
            this.button2.Name = "button2";
            this.helpProvider.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.helpProvider.SetHelpString(this.button3, "Opcja pozwalajaca wyszukac autorow w bazie");
            this.button3.Location = new System.Drawing.Point(27, 247);
            this.button3.Name = "button3";
            this.helpProvider.SetShowHelp(this.button3, true);
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 64;
            this.button3.Text = "Wyszukaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddAuthor
            // 
            this.helpProvider.SetHelpString(this.btnAddAuthor, "Uzyj tego przycisku, aby przeniesc wyszukane ksiazki do przypisanych");
            this.btnAddAuthor.Location = new System.Drawing.Point(145, 161);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.helpProvider.SetShowHelp(this.btnAddAuthor, true);
            this.btnAddAuthor.Size = new System.Drawing.Size(39, 37);
            this.btnAddAuthor.TabIndex = 63;
            this.btnAddAuthor.Text = ">>";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Przypisane do książki";
            // 
            // lstViewAddedAuthors
            // 
            this.lstViewAddedAuthors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.helpProvider.SetHelpString(this.lstViewAddedAuthors, "Lista autorow przypisanych do tytulu ksiazki");
            this.lstViewAddedAuthors.Location = new System.Drawing.Point(190, 115);
            this.lstViewAddedAuthors.Name = "lstViewAddedAuthors";
            this.helpProvider.SetShowHelp(this.lstViewAddedAuthors, true);
            this.lstViewAddedAuthors.Size = new System.Drawing.Size(112, 126);
            this.lstViewAddedAuthors.TabIndex = 61;
            this.lstViewAddedAuthors.UseCompatibleStateImageBehavior = false;
            this.lstViewAddedAuthors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Imię";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Wyszukiwanie";
            // 
            // lstViewSearchAuthor
            // 
            this.lstViewSearchAuthor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.helpProvider.SetHelpString(this.lstViewSearchAuthor, "Lista autorow znajdujacych sie w bazie");
            this.lstViewSearchAuthor.Location = new System.Drawing.Point(27, 115);
            this.lstViewSearchAuthor.Name = "lstViewSearchAuthor";
            this.helpProvider.SetShowHelp(this.lstViewSearchAuthor, true);
            this.lstViewSearchAuthor.Size = new System.Drawing.Size(112, 126);
            this.lstViewSearchAuthor.TabIndex = 59;
            this.lstViewSearchAuthor.UseCompatibleStateImageBehavior = false;
            this.lstViewSearchAuthor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Imię";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Autorzy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Rodzaj";
            // 
            // genreSpinner
            // 
            this.genreSpinner.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.genreSpinner, "Tutaj wybierz rodzaj ksiazki");
            this.genreSpinner.Location = new System.Drawing.Point(102, 292);
            this.genreSpinner.Name = "genreSpinner";
            this.helpProvider.SetShowHelp(this.genreSpinner, true);
            this.genreSpinner.Size = new System.Drawing.Size(223, 21);
            this.genreSpinner.TabIndex = 67;
            // 
            // helpButton
            // 
            this.helpProvider.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(217, 8);
            this.helpButton.Name = "helpButton";
            this.helpProvider.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(108, 23);
            this.helpButton.TabIndex = 68;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 372);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.genreSpinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstViewAddedAuthors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstViewSearchAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "BookForm";
            this.Text = "Książka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstViewAddedAuthors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstViewSearchAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genreSpinner;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button helpButton;
    }
}