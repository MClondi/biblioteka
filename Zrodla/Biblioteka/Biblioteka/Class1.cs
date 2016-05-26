using Biblioteka.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteka
{
    class Class1
    {
        public Class1()
        {
            using (var db = new LibraryDBContainer())
                {
                    var query = from u in db.Users
                                orderby u.Surname, u.Name
                                select u;
                    foreach (var user in query)
                    {
                        db.Users.Remove(user);
                    }
                    var jpAdmin = new User
                    {
                        Login = "User0",
                        Password = "User0",
                        Name = "Jakub",
                        Surname = "Plachta",
                        Type = "A",
                        E_Mail = "jp@polsl.pl"
                    };
                    var jpUser = new User
                    {
                        Login = "User1",
                        Password = "User1",
                        Name = "Jakub2",
                        Surname = "Plachta",
                        Type = "U",
                        E_Mail = "jp@polsl.pl"
                    };
                    var newUser = new User
                    {
                        Login = "User2",
                        Password = "User2",
                        Name = "Jakub3",
                        Surname = "Plachta",
                        Type = "L",
                        E_Mail = "jp@polsl.pl"
                    };
                    var author1 = new Author
                    {
                        Name = "JPPisarz",
                        Surname = "JP",
                    };
                    var genre = new Genre()
                    {
                        Name = "JPGenre",
                    };
                    var book = new Book
                    {
                        Title = "JpLubiCzytać",
                        GenreId = 0,
                    };
                    db.Authors.Add(author1);
                    db.Genres.Add(genre);
                    db.Books.Add(book);
                    db.Users.Add(jpAdmin);  
                    db.Users.Add(jpUser);
                    db.Users.Add(newUser);
                    db.SaveChanges();   
                    
                }
        }
    }
}
