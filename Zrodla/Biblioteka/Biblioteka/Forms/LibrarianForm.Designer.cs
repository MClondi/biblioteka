namespace Biblioteka.Forms
{
    partial class LibrarianForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstViewBooksAndUsers = new System.Windows.Forms.ListView();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnBorrowResource = new System.Windows.Forms.Button();
            this.btnReserveResource = new System.Windows.Forms.Button();
            this.btnNoteReturn = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.btnEditResource = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnEditPosition = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchPosition = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.helpProvider1.SetHelpString(this.btnLogout, "Przycisk pozwalajacy wylogowac sie");
            this.btnLogout.Location = new System.Drawing.Point(617, 12);
            this.btnLogout.Name = "btnLogout";
            this.helpProvider1.SetShowHelp(this.btnLogout, true);
            this.btnLogout.Size = new System.Drawing.Size(112, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Wyloguj sie";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstViewBooksAndUsers
            // 
            this.helpProvider1.SetHelpString(this.lstViewBooksAndUsers, "Lista uzytkownikow bedacych w systemie");
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(12, 63);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.helpProvider1.SetShowHelp(this.lstViewBooksAndUsers, true);
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(143, 196);
            this.lstViewBooksAndUsers.TabIndex = 7;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewBooksAndUsers.View = System.Windows.Forms.View.List;
            // 
            // btnSearchUser
            // 
            this.helpProvider1.SetHelpString(this.btnSearchUser, "Przycisk pozwalający na wyszukanie użytkownika");
            this.btnSearchUser.Location = new System.Drawing.Point(17, 25);
            this.btnSearchUser.Name = "btnSearchUser";
            this.helpProvider1.SetShowHelp(this.btnSearchUser, true);
            this.btnSearchUser.Size = new System.Drawing.Size(112, 24);
            this.btnSearchUser.TabIndex = 8;
            this.btnSearchUser.Text = "Szukaj użytkownika";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnBorrowResource
            // 
            this.helpProvider1.SetHelpString(this.btnBorrowResource, "Przycisk pozwalający wypożyczyć zasób");
            this.btnBorrowResource.Location = new System.Drawing.Point(15, 55);
            this.btnBorrowResource.Name = "btnBorrowResource";
            this.helpProvider1.SetShowHelp(this.btnBorrowResource, true);
            this.btnBorrowResource.Size = new System.Drawing.Size(112, 24);
            this.btnBorrowResource.TabIndex = 13;
            this.btnBorrowResource.Text = "Wypożycz zasób";
            this.btnBorrowResource.UseVisualStyleBackColor = true;
            this.btnBorrowResource.Click += new System.EventHandler(this.btnBorrowResource_Click);
            // 
            // btnReserveResource
            // 
            this.helpProvider1.SetHelpString(this.btnReserveResource, "Przycisk pozwalający zarezerwować zasoby dla użytkownika");
            this.btnReserveResource.Location = new System.Drawing.Point(15, 25);
            this.btnReserveResource.Name = "btnReserveResource";
            this.helpProvider1.SetShowHelp(this.btnReserveResource, true);
            this.btnReserveResource.Size = new System.Drawing.Size(112, 24);
            this.btnReserveResource.TabIndex = 14;
            this.btnReserveResource.Text = "Zarezerwuj zasób";
            this.btnReserveResource.UseVisualStyleBackColor = true;
            this.btnReserveResource.Click += new System.EventHandler(this.btnReserveResource_Click);
            // 
            // btnNoteReturn
            // 
            this.helpProvider1.SetHelpString(this.btnNoteReturn, "Przycisk zapisujący zwrot zasobu, umieszczajacy go autmatycznie w bazie wolnych z" +
        "asobów");
            this.btnNoteReturn.Location = new System.Drawing.Point(15, 115);
            this.btnNoteReturn.Name = "btnNoteReturn";
            this.helpProvider1.SetShowHelp(this.btnNoteReturn, true);
            this.btnNoteReturn.Size = new System.Drawing.Size(112, 24);
            this.btnNoteReturn.TabIndex = 15;
            this.btnNoteReturn.Text = "Zaksięguj zwrot";
            this.btnNoteReturn.UseVisualStyleBackColor = true;
            this.btnNoteReturn.Click += new System.EventHandler(this.btnNoteReturn_Click);
            // 
            // btnCancelReservation
            // 
            this.helpProvider1.SetHelpString(this.btnCancelReservation, "Przycisk usuwający rezerwację");
            this.btnCancelReservation.Location = new System.Drawing.Point(15, 85);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.helpProvider1.SetShowHelp(this.btnCancelReservation, true);
            this.btnCancelReservation.Size = new System.Drawing.Size(112, 24);
            this.btnCancelReservation.TabIndex = 16;
            this.btnCancelReservation.Text = "Usuń rezerwację";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // btnDeleteResource
            // 
            this.helpProvider1.SetHelpString(this.btnDeleteResource, "Przycisk usuwający zasób ze stanu biblioteki");
            this.btnDeleteResource.Location = new System.Drawing.Point(20, 86);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.helpProvider1.SetShowHelp(this.btnDeleteResource, true);
            this.btnDeleteResource.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteResource.TabIndex = 21;
            this.btnDeleteResource.Text = "Usuń zasób";
            this.btnDeleteResource.UseVisualStyleBackColor = true;
            this.btnDeleteResource.Click += new System.EventHandler(this.btnDeleteResource_Click);
            // 
            // btnDeleteAuthor
            // 
            this.helpProvider1.SetHelpString(this.btnDeleteAuthor, "Przycisk usuwający autora z listy ");
            this.btnDeleteAuthor.Location = new System.Drawing.Point(148, 86);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.helpProvider1.SetShowHelp(this.btnDeleteAuthor, true);
            this.btnDeleteAuthor.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteAuthor.TabIndex = 20;
            this.btnDeleteAuthor.Text = "Usuń autora";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnDeletePosition
            // 
            this.helpProvider1.SetHelpString(this.btnDeletePosition, "Przycisk usuwający pozycję z listy");
            this.btnDeletePosition.Location = new System.Drawing.Point(275, 86);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.helpProvider1.SetShowHelp(this.btnDeletePosition, true);
            this.btnDeletePosition.Size = new System.Drawing.Size(112, 23);
            this.btnDeletePosition.TabIndex = 22;
            this.btnDeletePosition.Text = "Usuń pozycję";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // btnEditResource
            // 
            this.helpProvider1.SetHelpString(this.btnEditResource, "Przycisk włączający edycję zasobu bibliotecznego");
            this.btnEditResource.Location = new System.Drawing.Point(20, 56);
            this.btnEditResource.Name = "btnEditResource";
            this.helpProvider1.SetShowHelp(this.btnEditResource, true);
            this.btnEditResource.Size = new System.Drawing.Size(112, 23);
            this.btnEditResource.TabIndex = 18;
            this.btnEditResource.Text = "Edytuj zasób";
            this.btnEditResource.UseVisualStyleBackColor = true;
            this.btnEditResource.Click += new System.EventHandler(this.btnEditResource_Click);
            // 
            // btnEditAuthor
            // 
            this.helpProvider1.SetHelpString(this.btnEditAuthor, "Przycisk umożliwiający edycję istniejącego autora");
            this.btnEditAuthor.Location = new System.Drawing.Point(148, 56);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.helpProvider1.SetShowHelp(this.btnEditAuthor, true);
            this.btnEditAuthor.Size = new System.Drawing.Size(112, 23);
            this.btnEditAuthor.TabIndex = 17;
            this.btnEditAuthor.Text = "Edytuj autora";
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            // 
            // btnEditPosition
            // 
            this.helpProvider1.SetHelpString(this.btnEditPosition, "Przycisk umożliwiający edycję istniejącej pozycji");
            this.btnEditPosition.Location = new System.Drawing.Point(275, 56);
            this.btnEditPosition.Name = "btnEditPosition";
            this.helpProvider1.SetShowHelp(this.btnEditPosition, true);
            this.btnEditPosition.Size = new System.Drawing.Size(112, 23);
            this.btnEditPosition.TabIndex = 19;
            this.btnEditPosition.Text = "Edytuj pozycję";
            this.btnEditPosition.UseVisualStyleBackColor = true;
            this.btnEditPosition.Click += new System.EventHandler(this.btnEditPosition_Click);
            // 
            // btnAddResource
            // 
            this.helpProvider1.SetHelpString(this.btnAddResource, "Przycisk pozwalający dodać nowy zasób do bazy biblioteki");
            this.btnAddResource.Location = new System.Drawing.Point(20, 26);
            this.btnAddResource.Name = "btnAddResource";
            this.helpProvider1.SetShowHelp(this.btnAddResource, true);
            this.btnAddResource.Size = new System.Drawing.Size(112, 23);
            this.btnAddResource.TabIndex = 14;
            this.btnAddResource.Text = "Dodaj zasób";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnAddAuthor
            // 
            this.helpProvider1.SetHelpString(this.btnAddAuthor, "Przycisk umożliwiający dodanie nowego autora do listy");
            this.btnAddAuthor.Location = new System.Drawing.Point(148, 26);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.helpProvider1.SetShowHelp(this.btnAddAuthor, true);
            this.btnAddAuthor.Size = new System.Drawing.Size(112, 23);
            this.btnAddAuthor.TabIndex = 13;
            this.btnAddAuthor.Text = "Dodaj autora";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddPosition
            // 
            this.helpProvider1.SetHelpString(this.btnAddPosition, "Przycisk umozliwiający dodanie nowej pozycji do listy");
            this.btnAddPosition.Location = new System.Drawing.Point(275, 26);
            this.btnAddPosition.Name = "btnAddPosition";
            this.helpProvider1.SetShowHelp(this.btnAddPosition, true);
            this.btnAddPosition.Size = new System.Drawing.Size(112, 23);
            this.btnAddPosition.TabIndex = 16;
            this.btnAddPosition.Text = "Dodaj pozycję";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSearchUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 166);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Użytkownicy";
            // 
            // button2
            // 
            this.helpProvider1.SetHelpString(this.button2, "Przycisk pozwalający sprawdzić zasoby zarezerwowane przez użytkownika");
            this.button2.Location = new System.Drawing.Point(17, 109);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(112, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sprawdź zarezerwowane zasoby";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Przycisk pozwalający sprawdzić zasoby wypożyczone przez użytkownika");
            this.button1.Location = new System.Drawing.Point(17, 55);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sprawdź wypożyczone zasoby";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReserveResource);
            this.groupBox3.Controls.Add(this.btnBorrowResource);
            this.groupBox3.Controls.Add(this.btnNoteReturn);
            this.groupBox3.Controls.Add(this.btnCancelReservation);
            this.groupBox3.Location = new System.Drawing.Point(170, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 166);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Akcje";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchPosition);
            this.groupBox4.Controls.Add(this.btnSearchAuthor);
            this.groupBox4.Controls.Add(this.btnSearchResource);
            this.groupBox4.Controls.Add(this.btnDeleteResource);
            this.groupBox4.Controls.Add(this.btnAddResource);
            this.groupBox4.Controls.Add(this.btnDeleteAuthor);
            this.groupBox4.Controls.Add(this.btnAddPosition);
            this.groupBox4.Controls.Add(this.btnDeletePosition);
            this.groupBox4.Controls.Add(this.btnAddAuthor);
            this.groupBox4.Controls.Add(this.btnEditResource);
            this.groupBox4.Controls.Add(this.btnEditPosition);
            this.groupBox4.Controls.Add(this.btnEditAuthor);
            this.groupBox4.Location = new System.Drawing.Point(328, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 166);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Baza danych";
            // 
            // btnSearchPosition
            // 
            this.helpProvider1.SetHelpString(this.btnSearchPosition, "Przycisk pozwalający wyszukać pozycji w bazie biblioteki");
            this.btnSearchPosition.Location = new System.Drawing.Point(276, 116);
            this.btnSearchPosition.Name = "btnSearchPosition";
            this.helpProvider1.SetShowHelp(this.btnSearchPosition, true);
            this.btnSearchPosition.Size = new System.Drawing.Size(112, 23);
            this.btnSearchPosition.TabIndex = 25;
            this.btnSearchPosition.Text = "Szukaj pozycji";
            this.btnSearchPosition.UseVisualStyleBackColor = true;
            // 
            // btnSearchAuthor
            // 
            this.helpProvider1.SetHelpString(this.btnSearchAuthor, "Przycisk pozwalający wyszukać autora w bazie autorów biblioteki");
            this.btnSearchAuthor.Location = new System.Drawing.Point(148, 116);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.helpProvider1.SetShowHelp(this.btnSearchAuthor, true);
            this.btnSearchAuthor.Size = new System.Drawing.Size(112, 23);
            this.btnSearchAuthor.TabIndex = 24;
            this.btnSearchAuthor.Text = "Szukaj autora";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // btnSearchResource
            // 
            this.helpProvider1.SetHelpString(this.btnSearchResource, "Przycisk wyszukujący zasobu będącego na stanie biblioteki");
            this.btnSearchResource.Location = new System.Drawing.Point(20, 116);
            this.btnSearchResource.Name = "btnSearchResource";
            this.helpProvider1.SetShowHelp(this.btnSearchResource, true);
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 23;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.helpProvider1.SetHelpString(this.listView2, "Lista pozycji w bibliotece");
            this.listView2.Location = new System.Drawing.Point(603, 63);
            this.listView2.Name = "listView2";
            this.helpProvider1.SetShowHelp(this.listView2, true);
            this.listView2.Size = new System.Drawing.Size(119, 196);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // listView3
            // 
            this.helpProvider1.SetHelpString(this.listView3, "Lista autorow ktorych dzieła znajduja sie w bibliotece");
            this.listView3.Location = new System.Drawing.Point(476, 63);
            this.listView3.Name = "listView3";
            this.helpProvider1.SetShowHelp(this.listView3, true);
            this.listView3.Size = new System.Drawing.Size(112, 196);
            this.listView3.TabIndex = 31;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // listView4
            // 
            this.helpProvider1.SetHelpString(this.listView4, "Lista zasobow bedacych w systemie");
            this.listView4.Location = new System.Drawing.Point(328, 63);
            this.listView4.Name = "listView4";
            this.helpProvider1.SetShowHelp(this.listView4, true);
            this.listView4.Size = new System.Drawing.Size(132, 196);
            this.listView4.TabIndex = 32;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.List;
            // 
            // listView1
            // 
            this.helpProvider1.SetHelpString(this.listView1, "Lista dodatkowych informacji");
            this.listView1.Location = new System.Drawing.Point(170, 63);
            this.listView1.Name = "listView1";
            this.helpProvider1.SetShowHelp(this.listView1, true);
            this.listView1.Size = new System.Drawing.Size(142, 196);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Użytkownicy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Dodatkowe informacje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Zasoby";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Autorzy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Pozycje";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(439, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(162, 23);
            this.helpButton.TabIndex = 39;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 436);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstViewBooksAndUsers);
            this.Controls.Add(this.btnLogout);
            this.Name = "LibrarianForm";
            this.Text = "Panel bibliotekarza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibrarianForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView lstViewBooksAndUsers;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnBorrowResource;
        private System.Windows.Forms.Button btnReserveResource;
        private System.Windows.Forms.Button btnNoteReturn;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Button btnEditResource;
        private System.Windows.Forms.Button btnEditAuthor;
        private System.Windows.Forms.Button btnEditPosition;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.Button btnSearchPosition;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}