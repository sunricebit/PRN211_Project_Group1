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

namespace Project
{
    public partial class frmProduct : Form
    {
        IProductRepository repository = new ProductRepository();
        IHistoryRepository historyRepository = new HistoryRepository();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product pro = null;
            History history = null;
            try
            {
                pro = new Product
                {
                    ProductName = txtProductName.Text,
                    Price = int.Parse(txtPrice.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    ProviderId = int.Parse(txtProviderID.Text),
                };
                repository.AddProduct(pro);
                var newpro = repository.GetProduct(pro.ProductName);
                if (newpro != null)
                {
                    int id = newpro.Id;
                    history = new History
                    {
                        Status = "Done",
                        TransactionDate = DateTime.Now,
                        Quatity = int.Parse(txtQuantity.Text),
                        Note = txtNote.Text,
                        ProductId = id
                    };
                    historyRepository.AddHistory(history);
                }
                MessageBox.Show("Add success! View your history!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("At least 1 of the fields has invalid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
