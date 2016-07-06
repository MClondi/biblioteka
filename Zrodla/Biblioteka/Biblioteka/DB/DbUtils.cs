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
            List<Borrowing> borrowings = dbContext.Borrowings
                                            .Include("User")
                                            .Include("Reader")
                                            .Include("Resource")
                                            .Where(b => b.ResourceId == resource.Id)
                                            .Where(b => b.ReturnDate == null)
                                            .ToList();

            if(borrowings != null)
            {
                if (borrowings.Count >= resource.Amount)
                    return true;
            }

            return false;
        }

        public static bool IsResourceReserved(LibraryDBContainer dbContext, Resource resource)
        {
            foreach (Reservation reservation in dbContext.Reservations)
            {
                if (reservation.ResourceId == resource.Id && reservation.RealizationDate > DateTime.Now)
                    return true;
            }

            return false;
        }

        public static bool IsResourceReservedForUser(LibraryDBContainer dbContext, Resource resource, Reader user)
        {
            foreach (Reservation reservation in dbContext.Reservations)
            {
                if (reservation.ResourceId == resource.Id && reservation.RealizationDate > DateTime.Now)
                    if(reservation.ReaderId == user.Id)
                        return true;
            }

            return false;
        }
    }
}
