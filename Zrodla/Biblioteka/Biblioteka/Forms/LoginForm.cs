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
    public partial class LoginForm : Form
    {
        LibraryDBContainer context;

        public LoginForm()
        {
            InitializeComponent();
            context = new LibraryDBContainer();
            if (context == null)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var query = from u in context.Users
                        where u.Login.Equals(txtBxUsername.Text)
                        where u.Password.Equals(txtBxPassword.Text)
                        select u;

            if (query.ToList().Count < 1)
            {
                MessageBox.Show("Wrong username or password.");
            } 
            else
            {
                switch (query.First().Type)
                {
                    case "A":
                        new AdminForm(this, context).Show();
                        break;
                    default:
                        break;
                }

            }
           
        }
    }
}
