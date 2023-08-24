using DataAccess;
using PRN211_Project_Group1.DataAccess;
using PRN211_Project_Group1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace FurnitureWinApp
{
    public partial class frmCategoryManagement : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        CategoryRepository repository = new CategoryRepository();
        public Account account { get; set; }
        frmLogin frm;
        BindingSource source = new BindingSource();
        IEnumerable<Category> DataSource;
        public frmCategoryManagement(Account acc, frmLogin Login)
        {
            InitializeComponent();
            this.account = acc;
            this.frm = Login;
        }

        private void frmCategoryManagement_Load(object sender, EventArgs e)
        {
            grActions.Enabled = false;
            grSearch.Enabled = false;
            btnLoad.Enabled = true;

            dgvCategory.Enabled = false;
        }
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            LoadList();
            LoadCategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategory form = new frmCategory();
            form.Show();

            form.FormClosed += new FormClosedEventHandler(formClosed);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cboID.Text);
                var p = repository.GetCategory(id);
                if (p != null && MessageBox.Show("Do you want to delete this category?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repository.RemoveCategory(p.Id);
                    MessageBox.Show("Delete success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCategoryList();
                    LoadList();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Can not delete category!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }



        private Category GetCategory()
        {
            Category cate = null;
            try
            {
                cate = new Category
                {
                    CategoryName = txtCateName.Text,
                    Id = int.Parse(cboID.SelectedValue.ToString()),
                };
            }
            catch (Exception ex) { MessageBox.Show("At least 1 of the fields has invalid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return cate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Category p = GetCategory();
                if (p != null)
                {
                    repository.UpdateCategory(p);
                    MessageBox.Show("Update success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();
                    LoadCategoryList();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Can not update product! ({ex.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadCategoryList()
        {
            var category = repository.GetCategoryList();
            try
            {
                source.DataSource = category;
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = source;

                cboID.DataSource = null;
                cboID.DataSource = category.Where(p => p.Id != null).ToList();
                cboID.DisplayMember = "Id";
                cboID.ValueMember = "Id";

                int id = int.Parse(cboID.Text);
                Category p = context.Categories.SingleOrDefault(x => x.Id == id);
                txtCateName.Text = p.CategoryName;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() //Load product list
        {
            var category = repository.GetCategoryList();
            var categorylist = context.Categories.OrderBy(p => p.Id).ToList(); //get list by id
            DataSource = categorylist;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            grActions.Enabled = true;
            grSearch.Enabled = true;

            dgvCategory.Enabled = true;

            LoadList();
            LoadCategoryList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Category> categoryList = new List<Category>();
            try
            {
                if (rdName.Checked)
                {
                    string searchVal = txtSearch.Text;
                    categoryList = context.Categories
                                    .Where(p => p.CategoryName.Contains(searchVal))
                                    .ToList();
                    if (categoryList.Any())
                    {
                        dgvCategory.DataSource = categoryList;
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search category", MessageBoxButtons.OK);
                    }
                }
                else if (rdID.Checked)
                {
                    int searchVal = 0;
                    if (!(int.TryParse(txtSearch.Text, out searchVal)))
                    {
                        categoryList = context.Categories
                                    .OrderBy(p => p.Id)
                                    .ToList();
                    }
                    else
                    {
                        categoryList = context.Categories
                                    .Where(p => p.Id == searchVal)
                                    .ToList();
                    }


                    if (categoryList.Any())
                    {
                        dgvCategory.DataSource = categoryList;
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search category", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search category", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main(frm, account);
            main.Show();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboID.DataSource != null)
                {
                    int id = int.Parse(cboID.SelectedValue.ToString());

                    var p = repository.GetCategory(id);

                    txtCateName.Text = p.CategoryName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
