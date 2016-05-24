using Biblioteka.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.Adapters
{
    class ListItemUser: ListViewItem
    {
        User user;

        public ListItemUser(User user)
        {
            this.user = user;
            this.Text = user.Name + " " + user.Surname + " " + user.Id.ToString();
            this.Tag = user;
        }

        public User getUser()
        {
            return user;
        }
    }
}
