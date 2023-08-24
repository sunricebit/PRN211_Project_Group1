using DataAccess;
using PRN211_Project_Group1;
using PRN211_Project_Group1.DataAccess;
using Project;
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
    public partial class frmProductManagement : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        IProductRepository productRepository = new ProductRepository();
        IHistoryRepository historyRepository = new HistoryRepository();
        public Account account { get; set; }
        frmLogin frm;
        BindingSource source = new BindingSource();
        IEnumerable<Product> DataSource;
        public frmProductManagement(Account account, frmLogin login)
        {
            InitializeComponent();
            this.account = account;
            this.frm = login;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (account.Role.Equals("Manager"))
            {
                grActions.Enabled = true;
                btnExport.Enabled = true;
                btnImport.Enabled = true;
            }
            grFilter.Enabled = true;
            grSearch.Enabled = true;
            dataGridView.Enabled = true;

            LoadProduct();
            LoadList();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchval = txtSearch.Text; //Get search value
                if (rbByID.Checked)
                {
                    int value = int.Parse(searchval);
                    IEnumerable<Product> products = productRepository.SearchProduct(value);
                    if (products.Any()) //Found
                    {
                        DataSource = products;
                        dataGridView.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("ID not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rbByCatID.Checked)
                {
                    int value = int.Parse(searchval);
                    IEnumerable<Product> products = productRepository.SearchProductByCat(value);
                    if (products.Any()) //Found
                    {
                        DataSource = products;
                        dataGridView.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("Category ID not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rbByProviderID.Checked)
                {
                    int value = int.Parse(searchval);
                    IEnumerable<Product> products = productRepository.SearchProductByProv(value);
                    if (products.Any()) //Found
                    {
                        DataSource = products;
                        dataGridView.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("Provider ID not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rbByName.Checked)
                {
                    string value = searchval;
                    IEnumerable<Product> products = productRepository.SearchProduct(value);
                    if (products.Any()) //Found
                    {
                        DataSource = products;
                        dataGridView.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("Name not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured! ({ex.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmProduct form = new frmProduct();
                form.Show();
                LoadProduct();
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            History history = null;
            try
            {
                int id = int.Parse(cboProductID.Text);
                var p = productRepository.GetProduct(id);
                if (p != null && MessageBox.Show("Do you want to delete this product entry?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    history = new History
                    {
                        ProductId = p.Id,
                        Quatity = p.Quantity,
                        Status = "Deleted",
                        Note = "None",
                        TransactionDate = DateTime.Now,
                    };
                    historyRepository.AddHistory(history);
                    productRepository.RemoveProduct(p.Id);
                    MessageBox.Show("Delete success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadProduct();
                    LoadList();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Can not delete product! ({ex.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            History history = null;
            try
            {
                Product p = GetProduct();
                if (p != null)
                {
                    productRepository.UpdateProduct(p);
                    MessageBox.Show("Update success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    history = new History
                    {
                        ProductId = p.Id,
                        Quatity = p.Quantity,
                        Status = "Updated",
                        Note = "None",
                        TransactionDate = DateTime.Now,
                    };
                    historyRepository.AddHistory(history);
                    LoadProduct();
                    LoadList();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Can not update product! ({ex.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main(frm, account);
            main.Show();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            grActions.Enabled = false;
            grFilter.Enabled = false;
            grSearch.Enabled = false;
            btnExport.Enabled = false;
            btnImport.Enabled = false;
            dataGridView.Enabled = false;
        }
        private void LoadProduct()
        {
            var products = productRepository.GetProductList();
            try
            {
                source.DataSource = products;
                dataGridView.DataSource = null;
                dataGridView.DataSource = source;
                cboProductID.DataSource = null;
                cboProductID.DataSource = products.Where(p => p.Id != null).ToList();
                cboProductID.DisplayMember = "Id";
                cboProductID.ValueMember = "Id";
                numCatFilter.Value = 0;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private Product GetProduct()
        {
            Product pro = null;
            try
            {
                pro = new Product
                {
                    ProductName = txtProductName.Text,
                    Price = int.Parse(txtPrice.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    Quantity = int.Parse(txtInStock.Text),
                    ProviderId = int.Parse(txtProviderID.Text),
                    Id = int.Parse(cboProductID.Text),
                };
            }
            catch (Exception ex) { MessageBox.Show("At least 1 of the fields has invalid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return pro;
        }
        private void LoadList() //Load product list
        {
            var product = productRepository.GetProductList();
            var productlist = context.Products.OrderBy(p => p.Id).ToList(); //get list by id
            DataSource = productlist;
        }

        private void numCatFilter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int value = (int)numCatFilter.Value;
                if (value == 0)
                {
                    LoadProduct();
                }
                else
                {
                    var products = productRepository.SearchProductByCat(value);
                    dataGridView.DataSource = products;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
