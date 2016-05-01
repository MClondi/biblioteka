using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dbExample();
        }

        // Przykład użycia Entity Framework
        private void dbExample()
        {
            using (var db = new LibraryDBContainer())
            {
                // Stworzenie nowego użytkownika
                var jpUser = new User
                {
                    Login = "JPlachta",
                    Password = "dbd6f191c70dcec79f290f22b247261b",
                    Name = "Jakub",
                    Surname = "Plachta",
                    Type = "A",
                    E_Mail = "jp@polsl.pl"
                };
                db.Users.Add(jpUser);   // Dodanie użytkownika do tabeli Users
                db.SaveChanges();   // Zapisanie zmian do bazy

                // Zapytanie do bazy pobierające wszystkich użytkowników.
                var query = from u in db.Users
                            orderby u.Surname, u.Name
                            select u;

                foreach (var user in query)
                {
                    dbExampleListBox.Items.Add(user.Surname + " " + user.Name);
                }
            }
        }
        // Koniec przykładu
    }
}
