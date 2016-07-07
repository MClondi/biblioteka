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
    public partial class ResourceForm : Form
    {
        private Position position;
        private LibraryDBContainer dbContext;
        FormAction formAction;
        Resource editedResource = null;

        public ResourceForm(LibraryDBContainer dbContext, Position position)
        {
            this.dbContext = dbContext;
            this.position = position;
            InitializeComponent();
            if(position == null)
            {
                MessageBox.Show("Nie wybrano pozycji!", "Błąd");
                this.Close();
            }
            txtBoxCategory.Text = GetCategory(position);
            formAction = FormAction.Add;
        }

        public ResourceForm(LibraryDBContainer dbContext, Resource resource)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.editedResource = resource;
            txtBoxCategory.Text = GetCategory(resource.Position);
            txtBoxAmount.Text = editedResource.Amount.ToString();
            formAction = FormAction.Edit;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!txtBoxAmount.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Tylko cyfry");
                return;
            }
            
            switch (formAction)
            {
                case FormAction.Add:
                    AddResource();
                    MessageBox.Show("Dodano zasób", "Informacja");
                    break;
                case FormAction.Edit:
                    EditResource(editedResource);
                    MessageBox.Show("Edytowano zasób", "Informacja");
                    break;
            }

            dbContext.SaveChanges();
            this.Close();
        }

        private void AddResource()
        {
            Resource resource = new Resource();            
            resource.Position = position;
            EditResource(resource);
            dbContext.Resources.Add(resource);
        }

        private void EditResource(Resource resource)
        {
            resource.Amount = Int32.Parse(txtBoxAmount.Text);
            resource.Category = txtBoxCategory.Text.ElementAt(0).ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetCategory(Position position)
        {
            if (position is BookEdition)
                return "Książka";
            else if (position is Game)
                return "Gra";
            else
                return "Numer magazynu";
        }
    }
}
