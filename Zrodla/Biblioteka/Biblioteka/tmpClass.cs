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
    class tmpClass
    {
        private bool adminFound;
        public tmpClass()
        {
            
            using (var db = new LibraryDBContainer())
            {
                var query = from u in db.Users
                            where u.Login.Equals("admin")
                            where u.Password.Equals("admin")
                            select u;
                if (query.ToList().Count < 1)
                {
                    var jpAdmin = new User
                    {
                        Login = "admin",
                        Password = "admin",
                        Name = "Jakub",
                        Surname = "Plachta",
                        Type = "A",
                        E_Mail = "jp@polsl.pl"
                    };
                    db.Users.Add(jpAdmin);
                    db.SaveChanges();
                }
            }
        }
    }
}