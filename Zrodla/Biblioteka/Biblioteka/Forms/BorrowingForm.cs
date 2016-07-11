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

namespace Biblioteka.Forms
{
    public partial class BorrowingForm : Form
    {
        private Resource resource;
        private Reader reader;
        private User librarian;
        private LibraryDBContainer dbContext;

        public BorrowingForm(LibraryDBContainer dbContext, Resource resource, Reader reader, User librarian)
        {
            this.resource = resource;
            this.reader = reader;
            this.librarian = librarian;
            this.dbContext = dbContext;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool borrowingOk = true; 

            if (datePicker.Value < DateTime.Today)
            {
                MessageBox.Show("Data oddania powinna być późniejsza");
                return;
            }

            if(DbUtils.IsResourceAvailable(dbContext, resource))
            {
                borrowingOk = BorrowResource();
            }
            else if(DbUtils.IsResourceReservedForUser(dbContext, resource, reader))
            {
                borrowingOk = BorrowResource();
            }
            else
            {
                MessageBox.Show("Zasób niedostępny!", "Błąd");
                borrowingOk = false;
            }

            if(borrowingOk)
                MessageBox.Show("Wypożyczono zasób!", "Informacja");
            this.Close();
        }

        private bool BorrowResource()
        {
            if (!DbUtils.HasUserAlreadyBorrowedResource(dbContext, resource, reader))
            {
                List<Reservation> reservations = dbContext.Reservations
                                                .Include("Reader")
                                                .Include("Resource")
                                                .Where(r => r.ReaderId == reader.Id)
                                                .Where(r => r.ResourceId == resource.Id)
                                                .ToList();
                dbContext.Reservations.RemoveRange(reservations);

                Borrowing borrowing = new Borrowing();

                borrowing.BorrowingDate = DateTime.Now;
                borrowing.ReturnDate = null;
                borrowing.ReturnTerm = datePicker.Value;
                borrowing.Reader = reader;
                borrowing.Resource = resource;
                borrowing.User = librarian;

                dbContext.Borrowings.Add(borrowing);
                dbContext.SaveChanges();

                return true;
            }

            MessageBox.Show("Użytkownik już wypożyczył ten zasób!", "Błąd");
            return false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
