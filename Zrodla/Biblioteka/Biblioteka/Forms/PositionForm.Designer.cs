namespace Biblioteka.Forms
{
    partial class PositionForm
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
            this.typeSpinner = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbBoxIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.publisherSpinner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstViewSelectedBook = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lstViewSearchBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxProducer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxEdition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.magazineSpinner = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.genreSpinner = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeSpinner
            // 
            this.typeSpinner.FormattingEnabled = true;
            this.typeSpinner.Items.AddRange(new object[] {
            "Książka",
            "Gra",
            "Numer magazynu"});
            this.typeSpinner.Location = new System.Drawing.Point(102, 47);
            this.typeSpinner.Name = "typeSpinner";
            this.typeSpinner.Size = new System.Drawing.Size(223, 21);
            this.typeSpinner.TabIndex = 28;
            this.typeSpinner.SelectedIndexChanged += new System.EventHandler(this.typeSpinner_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Typ";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(178, 513);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(148, 23);
            this.buttonExit.TabIndex = 41;
            this.buttonExit.Text = "Anuluj";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(16, 513);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 23);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "ISBN";
            // 
            // txbBoxIsbn
            // 
            this.txbBoxIsbn.Location = new System.Drawing.Point(102, 152);
            this.txbBoxIsbn.Name = "txbBoxIsbn";
            this.txbBoxIsbn.Size = new System.Drawing.Size(223, 20);
            this.txbBoxIsbn.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data publikacji";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(102, 178);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(223, 20);
            this.datePicker.TabIndex = 46;
            // 
            // publisherSpinner
            // 
            this.publisherSpinner.FormattingEnabled = true;
            this.publisherSpinner.Location = new System.Drawing.Point(102, 204);
            this.publisherSpinner.Name = "publisherSpinner";
            this.publisherSpinner.Size = new System.Drawing.Size(223, 21);
            this.publisherSpinner.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Wydawca";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 85;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 84;
            this.button3.Text = "Wyszukaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.Location = new System.Drawing.Point(149, 398);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(39, 37);
            this.btnSelectBook.TabIndex = 83;
            this.btnSelectBook.Text = ">>";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Wybrana książka";
            // 
            // lstViewSelectedBook
            // 
            this.lstViewSelectedBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lstViewSelectedBook.Location = new System.Drawing.Point(194, 352);
            this.lstViewSelectedBook.Name = "lstViewSelectedBook";
            this.lstViewSelectedBook.Size = new System.Drawing.Size(112, 126);
            this.lstViewSelectedBook.TabIndex = 81;
            this.lstViewSelectedBook.UseCompatibleStateImageBehavior = false;
            this.lstViewSelectedBook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tytuł";
            this.columnHeader3.Width = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Wyszukiwanie";
            // 
            // lstViewSearchBook
            // 
            this.lstViewSearchBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstViewSearchBook.Location = new System.Drawing.Point(31, 352);
            this.lstViewSearchBook.Name = "lstViewSearchBook";
            this.lstViewSearchBook.Size = new System.Drawing.Size(112, 126);
            this.lstViewSearchBook.TabIndex = 79;
            this.lstViewSearchBook.UseCompatibleStateImageBehavior = false;
            this.lstViewSearchBook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tytuł";
            this.columnHeader1.Width = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Książka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Nazwa";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(102, 74);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(223, 20);
            this.txtBoxName.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Producent";
            // 
            // txtBoxProducer
            // 
            this.txtBoxProducer.Location = new System.Drawing.Point(102, 100);
            this.txtBoxProducer.Name = "txtBoxProducer";
            this.txtBoxProducer.Size = new System.Drawing.Size(223, 20);
            this.txtBoxProducer.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Edycja";
            // 
            // txtBoxEdition
            // 
            this.txtBoxEdition.Location = new System.Drawing.Point(102, 126);
            this.txtBoxEdition.Name = "txtBoxEdition";
            this.txtBoxEdition.Size = new System.Drawing.Size(223, 20);
            this.txtBoxEdition.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Liczebność";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(102, 285);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(223, 20);
            this.txtBoxNumber.TabIndex = 92;
            // 
            // magazineSpinner
            // 
            this.magazineSpinner.FormattingEnabled = true;
            this.magazineSpinner.Location = new System.Drawing.Point(102, 231);
            this.magazineSpinner.Name = "magazineSpinner";
            this.magazineSpinner.Size = new System.Drawing.Size(223, 21);
            this.magazineSpinner.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 239);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Magazyn";
            // 
            // genreSpinner
            // 
            this.genreSpinner.FormattingEnabled = true;
            this.genreSpinner.Location = new System.Drawing.Point(102, 258);
            this.genreSpinner.Name = "genreSpinner";
            this.genreSpinner.Size = new System.Drawing.Size(223, 21);
            this.genreSpinner.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 96;
            this.label12.Text = "Rodzaj";
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 545);
            this.Controls.Add(this.genreSpinner);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.magazineSpinner);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxEdition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxProducer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSelectBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstViewSelectedBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstViewSearchBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.publisherSpinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbBoxIsbn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.typeSpinner);
            this.Controls.Add(this.label11);
            this.Name = "PositionForm";
            this.Text = "Pozycja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeSpinner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbBoxIsbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox publisherSpinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstViewSelectedBook;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstViewSearchBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxProducer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxEdition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.ComboBox magazineSpinner;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox genreSpinner;
        private System.Windows.Forms.Label label12;
    }
}