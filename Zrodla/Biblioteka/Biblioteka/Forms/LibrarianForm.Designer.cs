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
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.btnSearchPublisher = new System.Windows.Forms.Button();
            this.btnDeletePublisher = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnEditPublisher = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.lstViewPositions = new System.Windows.Forms.ListView();
            this.lstViewAuthors = new System.Windows.Forms.ListView();
            this.authorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstViewPublishers = new System.Windows.Forms.ListView();
            this.publisherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstViewBooks = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewMagazines = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewGenres = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchMagazine = new System.Windows.Forms.Button();
            this.btnDeleteMagazine = new System.Windows.Forms.Button();
            this.btnAddMagazine = new System.Windows.Forms.Button();
            this.btnEditMagazine = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpButton = new System.Windows.Forms.Button();
            this.btnRaport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.helpProvider1.SetHelpString(this.btnLogout, "Przycisk pozwalajacy wylogowac sie z aktualnie zalogowanego konta");
            this.btnLogout.Location = new System.Drawing.Point(730, 12);
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
            this.lstViewBooksAndUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userName,
            this.userSurname});
            this.helpProvider1.SetHelpString(this.lstViewBooksAndUsers, "Ekran przedstawiajacy uzytkownikow zarejestrowanych w bibliotece");
            this.lstViewBooksAndUsers.Location = new System.Drawing.Point(22, 28);
            this.lstViewBooksAndUsers.Name = "lstViewBooksAndUsers";
            this.helpProvider1.SetShowHelp(this.lstViewBooksAndUsers, true);
            this.lstViewBooksAndUsers.Size = new System.Drawing.Size(202, 133);
            this.lstViewBooksAndUsers.TabIndex = 7;
            this.lstViewBooksAndUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewBooksAndUsers.View = System.Windows.Forms.View.Details;
            // 
            // userName
            // 
            this.userName.Text = "Imię";
            this.userName.Width = 77;
            // 
            // userSurname
            // 
            this.userSurname.Text = "Nazwisko";
            this.userSurname.Width = 109;
            // 
            // btnSearchUser
            // 
            this.helpProvider1.SetHelpString(this.btnSearchUser, "Przycisk pozwalajacy wyszukac uzytkownika w bazie danych");
            this.btnSearchUser.Location = new System.Drawing.Point(45, 26);
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
            this.helpProvider1.SetHelpString(this.btnBorrowResource, "Przycisk pozwalajacy wypozyczyc zasob, ktory zostanie przypisane do uzytkownika");
            this.btnBorrowResource.Location = new System.Drawing.Point(48, 56);
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
            this.helpProvider1.SetHelpString(this.btnReserveResource, "Przycisk pozwalajacy zarezerwowac zasob");
            this.btnReserveResource.Location = new System.Drawing.Point(48, 26);
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
            this.helpProvider1.SetHelpString(this.btnNoteReturn, "Przycisk pozwalajacy zaksiegowac zwrot ksiazki wypozyczonej przez uzytkownika");
            this.btnNoteReturn.Location = new System.Drawing.Point(48, 116);
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
            this.helpProvider1.SetHelpString(this.btnCancelReservation, "Przycisk pozwalajacy usunac rezerwacje uzytkownika");
            this.btnCancelReservation.Location = new System.Drawing.Point(48, 86);
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
            this.helpProvider1.SetHelpString(this.btnDeleteResource, "Przycisk pozwalajacy usunac istniejacy zasob");
            this.btnDeleteResource.Location = new System.Drawing.Point(52, 86);
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
            this.helpProvider1.SetHelpString(this.btnDeleteAuthor, "Przycisk pozwalajacy usunac istniejacego autora");
            this.btnDeleteAuthor.Location = new System.Drawing.Point(18, 86);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.helpProvider1.SetShowHelp(this.btnDeleteAuthor, true);
            this.btnDeleteAuthor.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteAuthor.TabIndex = 20;
            this.btnDeleteAuthor.Text = "Usuń autora";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnDeletePosition
            // 
            this.helpProvider1.SetHelpString(this.btnDeletePosition, "Przycisk pozwalajacy usunac istniejaca pozycje");
            this.btnDeletePosition.Location = new System.Drawing.Point(246, 87);
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
            this.helpProvider1.SetHelpString(this.btnEditResource, "Przycisk pozwalajacy edytowac istniejacy zasob");
            this.btnEditResource.Location = new System.Drawing.Point(52, 56);
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
            this.helpProvider1.SetHelpString(this.btnEditAuthor, "Przycisk pozwalajacy edytowac isniejacego autora");
            this.btnEditAuthor.Location = new System.Drawing.Point(18, 56);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.helpProvider1.SetShowHelp(this.btnEditAuthor, true);
            this.btnEditAuthor.Size = new System.Drawing.Size(134, 23);
            this.btnEditAuthor.TabIndex = 17;
            this.btnEditAuthor.Text = "Edytuj autora";
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            // 
            // btnEditPosition
            // 
            this.helpProvider1.SetHelpString(this.btnEditPosition, "Przycisk pozwalajacy edytowac istniejaca pozycje");
            this.btnEditPosition.Location = new System.Drawing.Point(246, 57);
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
            this.helpProvider1.SetHelpString(this.btnAddResource, "Przycisk pozwalajacy dodac nowy zasob");
            this.btnAddResource.Location = new System.Drawing.Point(52, 26);
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
            this.helpProvider1.SetHelpString(this.btnAddAuthor, "Przycisk pozwalajacy dodac nowego autora");
            this.btnAddAuthor.Location = new System.Drawing.Point(18, 26);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.helpProvider1.SetShowHelp(this.btnAddAuthor, true);
            this.btnAddAuthor.Size = new System.Drawing.Size(134, 23);
            this.btnAddAuthor.TabIndex = 13;
            this.btnAddAuthor.Text = "Dodaj autora";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddPosition
            // 
            this.helpProvider1.SetHelpString(this.btnAddPosition, "Przycisk pozwalajacy dodac nowa pozycje ");
            this.btnAddPosition.Location = new System.Drawing.Point(246, 27);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 166);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Użytkownicy";
            // 
            // button2
            // 
            this.helpProvider1.SetHelpString(this.button2, "Przycisk pozwalajacy sprawdzic zarezerwowane zasoby przez uzytkownika");
            this.button2.Location = new System.Drawing.Point(45, 110);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(112, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sprawdź zarezerwowane zasoby";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Przycisk pozwalajacy sprawdzic zasoby wypozyczone przez uzytkownika");
            this.button1.Location = new System.Drawing.Point(45, 56);
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
            this.groupBox3.Location = new System.Drawing.Point(230, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 166);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Akcje";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchPosition);
            this.groupBox4.Controls.Add(this.btnSearchResource);
            this.groupBox4.Controls.Add(this.btnDeleteResource);
            this.groupBox4.Controls.Add(this.btnAddResource);
            this.groupBox4.Controls.Add(this.btnAddPosition);
            this.groupBox4.Controls.Add(this.btnDeletePosition);
            this.groupBox4.Controls.Add(this.btnEditResource);
            this.groupBox4.Controls.Add(this.btnEditPosition);
            this.groupBox4.Location = new System.Drawing.Point(438, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 166);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Baza danych";
            // 
            // btnSearchPosition
            // 
            this.helpProvider1.SetHelpString(this.btnSearchPosition, "Przycisk pozwalajacy wyszukac istniejacej pozycji w bazie");
            this.btnSearchPosition.Location = new System.Drawing.Point(246, 117);
            this.btnSearchPosition.Name = "btnSearchPosition";
            this.helpProvider1.SetShowHelp(this.btnSearchPosition, true);
            this.btnSearchPosition.Size = new System.Drawing.Size(112, 23);
            this.btnSearchPosition.TabIndex = 25;
            this.btnSearchPosition.Text = "Szukaj pozycji";
            this.btnSearchPosition.UseVisualStyleBackColor = true;
            this.btnSearchPosition.Click += new System.EventHandler(this.btnSearchPosition_Click);
            // 
            // btnSearchResource
            // 
            this.helpProvider1.SetHelpString(this.btnSearchResource, "Przycisk pozwalajacy wyszukac zasobu w bazie danych");
            this.btnSearchResource.Location = new System.Drawing.Point(52, 116);
            this.btnSearchResource.Name = "btnSearchResource";
            this.helpProvider1.SetShowHelp(this.btnSearchResource, true);
            this.btnSearchResource.Size = new System.Drawing.Size(112, 23);
            this.btnSearchResource.TabIndex = 23;
            this.btnSearchResource.Text = "Szukaj zasobu";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click_1);
            // 
            // btnSearchPublisher
            // 
            this.helpProvider1.SetHelpString(this.btnSearchPublisher, "Przycisk pozwalajacy wyszukac istniejacego wydawcy");
            this.btnSearchPublisher.Location = new System.Drawing.Point(187, 116);
            this.btnSearchPublisher.Name = "btnSearchPublisher";
            this.helpProvider1.SetShowHelp(this.btnSearchPublisher, true);
            this.btnSearchPublisher.Size = new System.Drawing.Size(134, 23);
            this.btnSearchPublisher.TabIndex = 29;
            this.btnSearchPublisher.Text = "Szukaj wydawcy";
            this.btnSearchPublisher.UseVisualStyleBackColor = true;
            this.btnSearchPublisher.Click += new System.EventHandler(this.btnSearchPublisher_Click);
            // 
            // btnDeletePublisher
            // 
            this.helpProvider1.SetHelpString(this.btnDeletePublisher, "Przycisk pozwalajacy usunac istniejacego wydawce");
            this.btnDeletePublisher.Location = new System.Drawing.Point(187, 86);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.helpProvider1.SetShowHelp(this.btnDeletePublisher, true);
            this.btnDeletePublisher.Size = new System.Drawing.Size(134, 23);
            this.btnDeletePublisher.TabIndex = 28;
            this.btnDeletePublisher.Text = "Usuń wydawcę";
            this.btnDeletePublisher.UseVisualStyleBackColor = true;
            this.btnDeletePublisher.Click += new System.EventHandler(this.btnDeletePublisher_Click);
            // 
            // btnAddPublisher
            // 
            this.helpProvider1.SetHelpString(this.btnAddPublisher, "Przycisk pozwalajacy dodac nowego wydawce");
            this.btnAddPublisher.Location = new System.Drawing.Point(187, 26);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.helpProvider1.SetShowHelp(this.btnAddPublisher, true);
            this.btnAddPublisher.Size = new System.Drawing.Size(134, 23);
            this.btnAddPublisher.TabIndex = 26;
            this.btnAddPublisher.Text = "Dodaj wydawcę";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnEditPublisher
            // 
            this.helpProvider1.SetHelpString(this.btnEditPublisher, "Przycisk pozwalajacy edytowac isniejacego wydawce");
            this.btnEditPublisher.Location = new System.Drawing.Point(187, 56);
            this.btnEditPublisher.Name = "btnEditPublisher";
            this.helpProvider1.SetShowHelp(this.btnEditPublisher, true);
            this.btnEditPublisher.Size = new System.Drawing.Size(134, 23);
            this.btnEditPublisher.TabIndex = 27;
            this.btnEditPublisher.Text = "Edytuj wydawcę";
            this.btnEditPublisher.UseVisualStyleBackColor = true;
            this.btnEditPublisher.Click += new System.EventHandler(this.btnEditPublisher_Click);
            // 
            // btnSearchAuthor
            // 
            this.helpProvider1.SetHelpString(this.btnSearchAuthor, "Przycisk pozwalajacy wyszukac istniejacego autora");
            this.btnSearchAuthor.Location = new System.Drawing.Point(18, 116);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.helpProvider1.SetShowHelp(this.btnSearchAuthor, true);
            this.btnSearchAuthor.Size = new System.Drawing.Size(134, 23);
            this.btnSearchAuthor.TabIndex = 24;
            this.btnSearchAuthor.Text = "Szukaj autora";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // lstViewPositions
            // 
            this.helpProvider1.SetHelpString(this.lstViewPositions, "Lista pozycji znajdujacych sie w bibliotece");
            this.lstViewPositions.Location = new System.Drawing.Point(646, 28);
            this.lstViewPositions.Name = "lstViewPositions";
            this.helpProvider1.SetShowHelp(this.lstViewPositions, true);
            this.lstViewPositions.Size = new System.Drawing.Size(202, 133);
            this.lstViewPositions.TabIndex = 30;
            this.lstViewPositions.UseCompatibleStateImageBehavior = false;
            this.lstViewPositions.View = System.Windows.Forms.View.Details;
            // 
            // lstViewAuthors
            // 
            this.lstViewAuthors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.authorName,
            this.authorSurname});
            this.helpProvider1.SetHelpString(this.lstViewAuthors, "Lista autorow ktorych ksiazki znajduja sie w bazie");
            this.lstViewAuthors.Location = new System.Drawing.Point(24, 23);
            this.lstViewAuthors.Name = "lstViewAuthors";
            this.helpProvider1.SetShowHelp(this.lstViewAuthors, true);
            this.lstViewAuthors.Size = new System.Drawing.Size(134, 133);
            this.lstViewAuthors.TabIndex = 31;
            this.lstViewAuthors.UseCompatibleStateImageBehavior = false;
            this.lstViewAuthors.View = System.Windows.Forms.View.Details;
            // 
            // authorName
            // 
            this.authorName.Text = "Imię";
            // 
            // authorSurname
            // 
            this.authorSurname.Text = "Nazwisko";
            // 
            // listView4
            // 
            this.helpProvider1.SetHelpString(this.listView4, "Lista zasobow wystepujacych w bibliotece");
            this.listView4.Location = new System.Drawing.Point(438, 28);
            this.listView4.Name = "listView4";
            this.helpProvider1.SetShowHelp(this.listView4, true);
            this.listView4.Size = new System.Drawing.Size(202, 133);
            this.listView4.TabIndex = 32;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.List;
            // 
            // listView1
            // 
            this.helpProvider1.SetHelpString(this.listView1, "Lista przedstawiajaca zasoby przypisane do uzytkownika");
            this.listView1.Location = new System.Drawing.Point(230, 28);
            this.listView1.Name = "listView1";
            this.helpProvider1.SetShowHelp(this.listView1, true);
            this.listView1.Size = new System.Drawing.Size(202, 133);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Użytkownicy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Dodatkowe informacje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Zasoby";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Autorzy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Pozycje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Wydawcy";
            // 
            // lstViewPublishers
            // 
            this.lstViewPublishers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.publisherName});
            this.helpProvider1.SetHelpString(this.lstViewPublishers, "Lista wydawcow, ktorych zasoby znajduja sie w bazie");
            this.lstViewPublishers.Location = new System.Drawing.Point(193, 23);
            this.lstViewPublishers.Name = "lstViewPublishers";
            this.helpProvider1.SetShowHelp(this.lstViewPublishers, true);
            this.lstViewPublishers.Size = new System.Drawing.Size(134, 133);
            this.lstViewPublishers.TabIndex = 39;
            this.lstViewPublishers.UseCompatibleStateImageBehavior = false;
            this.lstViewPublishers.View = System.Windows.Forms.View.Details;
            // 
            // publisherName
            // 
            this.publisherName.Text = "Nazwa";
            this.publisherName.Width = 95;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.helpProvider1.SetHelpString(this.tabControl1, "");
            this.tabControl1.Location = new System.Drawing.Point(9, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.helpProvider1.SetShowHelp(this.tabControl1, true);
            this.tabControl1.Size = new System.Drawing.Size(875, 370);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lstViewBooksAndUsers);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.lstViewPositions);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listView4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Główne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lstViewBooks);
            this.tabPage2.Controls.Add(this.lstViewMagazines);
            this.tabPage2.Controls.Add(this.lstViewGenres);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lstViewPublishers);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lstViewAuthors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pomocnicze";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Rodzaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Magazyny";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Książki";
            // 
            // lstViewBooks
            // 
            this.lstViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.helpProvider1.SetHelpString(this.lstViewBooks, "Lista ksiazek znajdujacych sie w bibliotece");
            this.lstViewBooks.Location = new System.Drawing.Point(365, 23);
            this.lstViewBooks.Name = "lstViewBooks";
            this.helpProvider1.SetShowHelp(this.lstViewBooks, true);
            this.lstViewBooks.Size = new System.Drawing.Size(134, 133);
            this.lstViewBooks.TabIndex = 56;
            this.lstViewBooks.UseCompatibleStateImageBehavior = false;
            this.lstViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tytuł";
            this.columnHeader4.Width = 95;
            // 
            // lstViewMagazines
            // 
            this.lstViewMagazines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.helpProvider1.SetHelpString(this.lstViewMagazines, "Lista magazynow znajdujacych sie w bibliotece");
            this.lstViewMagazines.Location = new System.Drawing.Point(530, 23);
            this.lstViewMagazines.Name = "lstViewMagazines";
            this.helpProvider1.SetShowHelp(this.lstViewMagazines, true);
            this.lstViewMagazines.Size = new System.Drawing.Size(134, 133);
            this.lstViewMagazines.TabIndex = 55;
            this.lstViewMagazines.UseCompatibleStateImageBehavior = false;
            this.lstViewMagazines.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nazwa";
            this.columnHeader3.Width = 95;
            // 
            // lstViewGenres
            // 
            this.lstViewGenres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.helpProvider1.SetHelpString(this.lstViewGenres, "Rodzaje zasobow znajdujacych sie w biblitoece");
            this.lstViewGenres.Location = new System.Drawing.Point(695, 23);
            this.lstViewGenres.Name = "lstViewGenres";
            this.helpProvider1.SetShowHelp(this.lstViewGenres, true);
            this.lstViewGenres.Size = new System.Drawing.Size(134, 133);
            this.lstViewGenres.TabIndex = 54;
            this.lstViewGenres.UseCompatibleStateImageBehavior = false;
            this.lstViewGenres.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwa";
            this.columnHeader2.Width = 95;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchMagazine);
            this.groupBox2.Controls.Add(this.btnDeleteMagazine);
            this.groupBox2.Controls.Add(this.btnAddMagazine);
            this.groupBox2.Controls.Add(this.btnEditMagazine);
            this.groupBox2.Controls.Add(this.btnSearchBook);
            this.groupBox2.Controls.Add(this.btnDeleteBook);
            this.groupBox2.Controls.Add(this.btnAddBook);
            this.groupBox2.Controls.Add(this.btnEditBook);
            this.groupBox2.Controls.Add(this.btnSearchPublisher);
            this.groupBox2.Controls.Add(this.btnDeletePublisher);
            this.groupBox2.Controls.Add(this.btnAddPublisher);
            this.groupBox2.Controls.Add(this.btnSearchAuthor);
            this.groupBox2.Controls.Add(this.btnAddAuthor);
            this.groupBox2.Controls.Add(this.btnDeleteAuthor);
            this.groupBox2.Controls.Add(this.btnEditPublisher);
            this.groupBox2.Controls.Add(this.btnSearchGenre);
            this.groupBox2.Controls.Add(this.btnDeleteGenre);
            this.groupBox2.Controls.Add(this.btnEditAuthor);
            this.groupBox2.Controls.Add(this.btnAddGenre);
            this.groupBox2.Controls.Add(this.btnEditGenre);
            this.groupBox2.Location = new System.Drawing.Point(6, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 166);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baza danych";
            // 
            // btnSearchMagazine
            // 
            this.helpProvider1.SetHelpString(this.btnSearchMagazine, "Przycisk pozwalajacy wyszukac istniejacego magazynu");
            this.btnSearchMagazine.Location = new System.Drawing.Point(524, 116);
            this.btnSearchMagazine.Name = "btnSearchMagazine";
            this.helpProvider1.SetShowHelp(this.btnSearchMagazine, true);
            this.btnSearchMagazine.Size = new System.Drawing.Size(134, 23);
            this.btnSearchMagazine.TabIndex = 45;
            this.btnSearchMagazine.Text = "Szukaj magazynu";
            this.btnSearchMagazine.UseVisualStyleBackColor = true;
            this.btnSearchMagazine.Click += new System.EventHandler(this.btnSearchMagazine_Click);
            // 
            // btnDeleteMagazine
            // 
            this.helpProvider1.SetHelpString(this.btnDeleteMagazine, "Przycisk pozwalajacy usunac istniejacy magazyn");
            this.btnDeleteMagazine.Location = new System.Drawing.Point(524, 86);
            this.btnDeleteMagazine.Name = "btnDeleteMagazine";
            this.helpProvider1.SetShowHelp(this.btnDeleteMagazine, true);
            this.btnDeleteMagazine.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteMagazine.TabIndex = 44;
            this.btnDeleteMagazine.Text = "Usuń magazyn";
            this.btnDeleteMagazine.UseVisualStyleBackColor = true;
            this.btnDeleteMagazine.Click += new System.EventHandler(this.btnDeleteMagazine_Click);
            // 
            // btnAddMagazine
            // 
            this.helpProvider1.SetHelpString(this.btnAddMagazine, "Przycisk pozwalajacy dodac nowy magazyn");
            this.btnAddMagazine.Location = new System.Drawing.Point(524, 26);
            this.btnAddMagazine.Name = "btnAddMagazine";
            this.helpProvider1.SetShowHelp(this.btnAddMagazine, true);
            this.btnAddMagazine.Size = new System.Drawing.Size(134, 23);
            this.btnAddMagazine.TabIndex = 42;
            this.btnAddMagazine.Text = "Dodaj magazyn";
            this.btnAddMagazine.UseVisualStyleBackColor = true;
            this.btnAddMagazine.Click += new System.EventHandler(this.btnAddMagazine_Click);
            // 
            // btnEditMagazine
            // 
            this.helpProvider1.SetHelpString(this.btnEditMagazine, "Przycisk pozwalajacy edytowac istniejaca magazyn");
            this.btnEditMagazine.Location = new System.Drawing.Point(524, 56);
            this.btnEditMagazine.Name = "btnEditMagazine";
            this.helpProvider1.SetShowHelp(this.btnEditMagazine, true);
            this.btnEditMagazine.Size = new System.Drawing.Size(134, 23);
            this.btnEditMagazine.TabIndex = 43;
            this.btnEditMagazine.Text = "Edytuj magazyn";
            this.btnEditMagazine.UseVisualStyleBackColor = true;
            this.btnEditMagazine.Click += new System.EventHandler(this.btnEditMagazine_Click);
            // 
            // btnSearchBook
            // 
            this.helpProvider1.SetHelpString(this.btnSearchBook, "Przycisk pozwalajacy wyszukac istniejacej ksiazki");
            this.btnSearchBook.Location = new System.Drawing.Point(359, 116);
            this.btnSearchBook.Name = "btnSearchBook";
            this.helpProvider1.SetShowHelp(this.btnSearchBook, true);
            this.btnSearchBook.Size = new System.Drawing.Size(134, 23);
            this.btnSearchBook.TabIndex = 41;
            this.btnSearchBook.Text = "Szukaj książki";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnDeleteBook
            // 
            this.helpProvider1.SetHelpString(this.btnDeleteBook, "Przycisk pozwalajacy usunac istniejaca ksiazke");
            this.btnDeleteBook.Location = new System.Drawing.Point(359, 86);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.helpProvider1.SetShowHelp(this.btnDeleteBook, true);
            this.btnDeleteBook.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteBook.TabIndex = 40;
            this.btnDeleteBook.Text = "Usuń książkę";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.helpProvider1.SetHelpString(this.btnAddBook, "Przycisk pozwalajacy dodac nowa ksiazke");
            this.btnAddBook.Location = new System.Drawing.Point(359, 26);
            this.btnAddBook.Name = "btnAddBook";
            this.helpProvider1.SetShowHelp(this.btnAddBook, true);
            this.btnAddBook.Size = new System.Drawing.Size(134, 23);
            this.btnAddBook.TabIndex = 38;
            this.btnAddBook.Text = "Dodaj książkę";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.helpProvider1.SetHelpString(this.btnEditBook, "Przycisk pozwalajacy edytowac istniejaca ksiazek");
            this.btnEditBook.Location = new System.Drawing.Point(359, 56);
            this.btnEditBook.Name = "btnEditBook";
            this.helpProvider1.SetShowHelp(this.btnEditBook, true);
            this.btnEditBook.Size = new System.Drawing.Size(134, 23);
            this.btnEditBook.TabIndex = 39;
            this.btnEditBook.Text = "Edytuj książkę";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnSearchGenre
            // 
            this.helpProvider1.SetHelpString(this.btnSearchGenre, "Przycisk pozwalajacy wyszukac istniejacego rodzaju");
            this.btnSearchGenre.Location = new System.Drawing.Point(689, 116);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.helpProvider1.SetShowHelp(this.btnSearchGenre, true);
            this.btnSearchGenre.Size = new System.Drawing.Size(134, 23);
            this.btnSearchGenre.TabIndex = 33;
            this.btnSearchGenre.Text = "Szukaj rodzaju";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.helpProvider1.SetHelpString(this.btnDeleteGenre, "Przycisk pozwalajacy usunac istniejacy rodzaj");
            this.btnDeleteGenre.Location = new System.Drawing.Point(689, 86);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.helpProvider1.SetShowHelp(this.btnDeleteGenre, true);
            this.btnDeleteGenre.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteGenre.TabIndex = 32;
            this.btnDeleteGenre.Text = "Usuń rodzaj";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnAddGenre
            // 
            this.helpProvider1.SetHelpString(this.btnAddGenre, "Przycisk pozwalajacy dodac nowy rodzaj");
            this.btnAddGenre.Location = new System.Drawing.Point(689, 26);
            this.btnAddGenre.Name = "btnAddGenre";
            this.helpProvider1.SetShowHelp(this.btnAddGenre, true);
            this.btnAddGenre.Size = new System.Drawing.Size(134, 23);
            this.btnAddGenre.TabIndex = 30;
            this.btnAddGenre.Text = "Dodaj rodzaj";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnEditGenre
            // 
            this.helpProvider1.SetHelpString(this.btnEditGenre, "Przycisk pozwalajacy edytowac istniejaca rodzaj");
            this.btnEditGenre.Location = new System.Drawing.Point(689, 55);
            this.btnEditGenre.Name = "btnEditGenre";
            this.helpProvider1.SetShowHelp(this.btnEditGenre, true);
            this.btnEditGenre.Size = new System.Drawing.Size(134, 23);
            this.btnEditGenre.TabIndex = 31;
            this.btnEditGenre.Text = "Edytuj rodzaj";
            this.btnEditGenre.UseVisualStyleBackColor = true;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEditGenre_Click);
            // 
            // helpButton
            // 
            this.helpProvider1.SetHelpString(this.helpButton, "Przycisk pozwalajacy wlaczyc/wylaczyc pomoc");
            this.helpButton.Location = new System.Drawing.Point(584, 12);
            this.helpButton.Name = "helpButton";
            this.helpProvider1.SetShowHelp(this.helpButton, true);
            this.helpButton.Size = new System.Drawing.Size(140, 23);
            this.helpButton.TabIndex = 51;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(451, 11);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(127, 23);
            this.btnRaport.TabIndex = 52;
            this.btnRaport.Text = "Generuj raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 428);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Name = "LibrarianForm";
            this.Text = "Panel bibliotekarza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibrarianForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListView lstViewPositions;
        private System.Windows.Forms.ListView lstViewAuthors;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader userSurname;
        private System.Windows.Forms.ColumnHeader authorName;
        private System.Windows.Forms.ColumnHeader authorSurname;
        private System.Windows.Forms.Button btnSearchPublisher;
        private System.Windows.Forms.Button btnDeletePublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnEditPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstViewPublishers;
        private System.Windows.Forms.ColumnHeader publisherName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstViewBooks;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstViewMagazines;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstViewGenres;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSearchMagazine;
        private System.Windows.Forms.Button btnDeleteMagazine;
        private System.Windows.Forms.Button btnAddMagazine;
        private System.Windows.Forms.Button btnEditMagazine;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button btnRaport;
    }
}