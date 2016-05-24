using Biblioteka.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    class ListItemBook : ListViewItem
    {
        Book book;

        public ListItemBook(Book book)
        {
            this.book = book;
            this.Text = book.Title + " " + book.Id.ToString();
            this.Tag = book;
        }

        public Book getBook()
        {
            return book;
        }
    }
}
