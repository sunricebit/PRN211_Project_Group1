using DataAccess;
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureWinApp
{
    public partial class frmCategory : Form
    {
        ICategoryRepository repository = new CategoryRepository();
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category cate = null;
            try
            {
                cate = new Category
                {
                    CategoryName = txtName.Text,
                };
                repository.AddCategory(cate);
                MessageBox.Show("Add successfully!!", "Add new category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("At least 1 of the fields has invalid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
