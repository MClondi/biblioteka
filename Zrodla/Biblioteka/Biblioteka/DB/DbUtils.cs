using Biblioteka.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public enum ResourceTypes { Book, Game, Magazine };

    class DbUtils
    {
        public static User AddReader(LibraryDBContainer dbContext, String login, String password, String name, String surname, String mail, String phone, String street, String houseNum, String aptNum, String city, String postal)
        {
            var user = AddUser("U", dbContext, login, password, name, surname, mail);
             
            if (user != null)
            {
                if (!phone.All(Char.IsDigit))
                {
                    MessageBox.Show("Telefon nie zawiera tylko cyfr");
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                    return null;
                }

                if (!postal.All(x => Char.IsDigit(x) || x == '-'))
                {
                    MessageBox.Show("Nieprawidłowy kod pocztowy");
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                    return null;
                }

                if (!houseNum.All(Char.IsDigit))
                {
                    MessageBox.Show("Numer domu nie zawiera tylko cyfr");
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                    return null;
                }

                        var newReader = new Reader
                        {
                            PhoneNumber = phone,
                            Street = street,
                            HouseNumber = houseNum,
                            ApartmentNumber = aptNum,
                            City = city,
                            PostalCode = postal,
                            Debt = 0,
                            User = user
                        };
                        user.Reader = newReader;

                        dbContext.Readers.Add(newReader);
                        dbContext.SaveChanges();
             }

            return user;
        }

        public static User AddUser(String type, LibraryDBContainer dbContext, String login, String password, String name, String surname, String mail)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(mail)) 
            {
                MessageBox.Show("Pola: Login, Haslo, Email, Imie, Nazwisko nie moga byc puste!");
                return null;
            }

            if (dbContext.Users.Any(x => x.Login == login))
            {
                MessageBox.Show("Użytkownik o podanym loginie istnieje!");
                return null;
            }

            if (! mail.Contains("@"))
            {
                MessageBox.Show("Email nieprawidłowy!");
                return null;
            }

            var newUser = new User
            {
                Login = login,
                Password = password,
                Name = name,
                Surname = surname,
                Type = type,
                E_Mail = mail
            };

            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();

            return newUser;
        }
    
        public static bool IsResourceBorrowed(LibraryDBContainer dbContext, Resource resource)
        {
            var resources = from r in dbContext.Resources
                            where r.PositionId == resource.PositionId
                            select r;

            foreach (Resource res in resources)
            {
                var bor = from b in dbContext.Borrowings
                          where b.ResourceId == res.Id
                          select b;

                foreach (Borrowing b in bor)
                {
                    if (b.ReturnDate > DateTime.Now)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
