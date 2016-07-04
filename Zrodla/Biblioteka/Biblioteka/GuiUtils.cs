using Biblioteka.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public class GuiUtils
    {
        public static T GetSelected<T>(ListView lstView, Dictionary<String, T> tagSet)
        {
            T entity = default(T);
            if (lstView.SelectedItems.Count > 0)
            {
                if (!tagSet.TryGetValue(lstView.SelectedItems[0].Tag.ToString(), out entity))
                {
                    MessageBox.Show("Błąd");
                }
            }

            return entity;
        }

        public static void RefreshAuthorListView(LibraryDBContainer dbContext, ref ListView lstViewAuthors,
                                  ref Dictionary<String, Author> authorTagSet, List<Author> authors = null)
        {
            if (authors == null)
            {
                authors = dbContext.Authors.ToList();
            }

            lstViewAuthors.Items.Clear();
            authorTagSet.Clear();
            foreach (Author author in authors)
            {
                string[] row = { author.Name, author.Surname };
                ListViewItem item = new ListViewItem(row);
                item.Tag = author.GetHashCode();
                authorTagSet.Add(item.Tag.ToString(), author);
                lstViewAuthors.Items.Add(item);
            }
        }

        public static void RefreshBookListView(LibraryDBContainer dbContext, ref ListView lstViewBooks,
                                  ref Dictionary<String, Book> bookTagSet, List<Book> books = null)
        {
            if (books == null)
            {
                books = dbContext.Books.ToList();
            }

            lstViewBooks.Items.Clear();
            bookTagSet.Clear();
            foreach (Book book in books)
            {
                string[] row = { book.Title };
                ListViewItem item = new ListViewItem(row);
                item.Tag = book.GetHashCode();
                bookTagSet.Add(item.Tag.ToString(), book);
                lstViewBooks.Items.Add(item);
            }
        }


        //public static void RefreshListView<T>(ListView lstView, Dictionary<String, T> tagSet, List<string[]> rows)
        //{
        //    lstView.Items.Clear();
        //    tagSet.Clear();
        //    foreach (string[] row in rows)
        //    {
        //        string[] newRow = row.Take(row.Length - 1).ToArray();
        //        ListViewItem item = new ListViewItem(newRow);
        //        item.Tag = row[row.Length];
        //        tagSet.Add(item.Tag.ToString(), usr);
        //        lstView.Items.Add(item);
        //    }
        //}

        //List<Author> aut = dbContext.Authors.ToList();
        //List<string[]> listOfRows = aut.Select(a => new[] { a.Name, a.Surname }).ToList();

    }
}
