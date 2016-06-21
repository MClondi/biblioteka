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
