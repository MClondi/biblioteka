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
            if (datePicker.Value < DateTime.Today)
            {
                MessageBox.Show("Data oddania powinna być późniejsza");
                return;
            }

            if(!DbUtils.IsResourceBorrowed(dbContext, resource) && !DbUtils.IsResourceReserved(dbContext, resource))
            {
                BorrowResource();
            }
            else if(DbUtils.IsResourceReservedForUser(dbContext, resource, reader))
            {
                BorrowReservedResource();
            }
            else
            {
                MessageBox.Show("Zasób niedostępny!", "Błąd");
                return;
            }    

            MessageBox.Show("Wypożyczono zasób!", "Informacja");
            this.Close();
        }

        private void BorrowResource()
        {
            Borrowing borrowing = new Borrowing();

            borrowing.BorrowingDate = DateTime.Now;
            borrowing.ReturnDate = null;
            borrowing.ReturnTerm = datePicker.Value;
            borrowing.Reader = reader;
            borrowing.Resource = resource;
            borrowing.User = librarian;

            dbContext.Borrowings.Add(borrowing);
            dbContext.SaveChanges();
        }

        private void BorrowReservedResource()
        {
            List<Reservation> reservations = dbContext.Reservations
                                                .Include("Reader")
                                                .Include("Resource")
                                                .Where(r => r.ReaderId == reader.Id)
                                                .Where(r => r.ResourceId == resource.Id)
                                                .ToList();
            dbContext.Reservations.RemoveRange(reservations);
            BorrowResource();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
