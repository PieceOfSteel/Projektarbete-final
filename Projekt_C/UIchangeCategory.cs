using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Projekt_C.Persistence;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Utilities;

namespace Projekt_C
{
    public delegate void CategoryUpdateHandler();

    public partial class UIchangeCategory : MetroForm
    {
        public event CategoryUpdateHandler CategoryUpdated;

        public UIchangeCategory()
        {
            InitializeComponent();
        }

        private void btnConfirmNewName_Click(object sender, EventArgs e)
        {
            var category = (Category)comboBoxCategories.SelectedItem;
            category.Name = txtBoxNewName.Text;
            UnitOfWork.Category.Update(category);
            updateComboBoxCategories();

            CategoryUpdated();
            Alert.CategoryChanged();
            txtBoxNewName.Clear();
        }

        private void updateComboBoxCategories()
        {
            var categories = UnitOfWork.Category.getAll();

            comboBoxCategories.Items.Clear();

            foreach (Category category in categories)
            {
                comboBoxCategories.Items.Add(category);
            }
        }

        private void UIchangeCategory_Load(object sender, EventArgs e)
        {
            updateComboBoxCategories();
        }

        private void UIchangeCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //    Hide();
            //}
        }
    }
}
