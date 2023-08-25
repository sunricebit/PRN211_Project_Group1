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
using Microsoft.EntityFrameworkCore.Migrations;
using System.Runtime.CompilerServices;
using FurnitureWinApp;

namespace Project
{
    public partial class frmProviderManagement : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        ProviderRepository providerRepository = new ProviderRepository();
        public Account account { get; set; }
        frmLogin frm;
        BindingSource source = new BindingSource();
        IEnumerable<Provider> DataSource;
        public frmProviderManagement(Account acc, frmLogin frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.account = acc;
        }

        private void frmProviderManagement_Load(object sender, EventArgs e)
        {
            cboProviderID.Enabled = false;
            txtProviderName.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            grSearch.Enabled = false;
            comboBox1.Enabled = false;
            btnLoad.Enabled = true;

            dgvProvider.Enabled = false;
        }

        private void LoadProviderList()
        {
            var provider = providerRepository.GetProviderList();
            try
            {
                source.DataSource = provider;
                dgvProvider.DataSource = null;
                dgvProvider.DataSource = source;
                comboBox1.SelectedIndex = 0;

                cboProviderID.DataSource = null;
                cboProviderID.DataSource = provider.Where(p => p.Id != null).ToList();
                cboProviderID.DisplayMember = "Id";
                cboProviderID.ValueMember = "Id";

                int id = int.Parse(cboProviderID.Text);
                Provider p = context.Providers.SingleOrDefault(x => x.Id == id);
                txtAddress.Text = p.Address;
                txtPhone.Text = p.Phone;
                txtProviderName.Text = p.ProviderName;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() //Load product list
        {
            var provider = providerRepository.GetProviderList();
            var providerlist = context.Providers.OrderBy(p => p.Id).ToList(); //get list by id
            DataSource = providerlist;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cboProviderID.Enabled = true;
            txtProviderName.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            grSearch.Enabled = true;
            comboBox1.Enabled = true;

            dgvProvider.Enabled = true;
            txtSearchValue.Clear();
            radioByID.Checked = true;

            LoadList();
            LoadProviderList();
        }

        private Provider GetProvider()
        {
            Provider pro = null;
            try
            {
                pro = new Provider
                {
                    ProviderName = txtProviderName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Id = int.Parse(cboProviderID.SelectedValue.ToString()),
                };
            }
            catch (Exception ex) { MessageBox.Show("At least 1 of the fields has invalid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return pro;
        }

        private void cboProviderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboProviderID.DataSource != null)
                {
                    int id = int.Parse(cboProviderID.SelectedValue.ToString());

                    var p = providerRepository.GetProvider(id);

                    txtAddress.Text = p.Address;
                    txtPhone.Text = p.Phone;
                    txtProviderName.Text = p.ProviderName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main(frm, account);
            main.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                Provider p = GetProvider();
                if (p != null)
                {
                    providerRepository.UpdateProvider(p);
                    MessageBox.Show("Update success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();
                    LoadProviderList();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Can not update product! ({ex.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            LoadList();
            LoadProviderList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmProvider form = new frmProvider();
            form.Show();

            form.FormClosed += new FormClosedEventHandler(formClosed);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cboProviderID.Text);
                var p = providerRepository.GetProvider(id);
                if (p != null && MessageBox.Show("Do you want to delete this product entry?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    providerRepository.RemoveProvider(p.Id);
                    MessageBox.Show("Delete success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadProviderList();
                    LoadList();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Can not delete provider! ({ex.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProviderID.DataSource != null)
            {
                string val = comboBox1.SelectedItem.ToString();
                var provider = providerRepository.GetProviderList();
                List<Provider> providerlist = new List<Provider>();
                switch (val)
                {
                    case "A-Z":
                        providerlist = context.Providers.OrderBy(p => p.ProviderName).ToList();
                        dgvProvider.DataSource = providerlist;
                        break;
                    case "Z-A":
                        providerlist = context.Providers.OrderByDescending(p => p.ProviderName).ToList();
                        dgvProvider.DataSource = providerlist;
                        break;
                    default:
                        providerlist = context.Providers.OrderBy(p => p.Id).ToList();
                        dgvProvider.DataSource = providerlist;
                        break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Provider> providerlist = new List<Provider>();
            try
            {
                if (radioByName.Checked)
                {
                    string searchVal = txtSearchValue.Text;
                    providerlist = context.Providers
                                    .Where(p => p.ProviderName.Contains(searchVal))
                                    .ToList();
                    if (providerlist.Any())
                    {
                        dgvProvider.DataSource = providerlist;
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK);
                    }
                }
                else if (radioByID.Checked)
                {
                    int searchVal = int.Parse(txtSearchValue.Text);
                    providerlist = context.Providers
                                    .Where(p => p.Id == searchVal)
                                    .ToList();

                    if (providerlist.Any())
                    {
                        dgvProvider.DataSource = providerlist;
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search provider", MessageBoxButtons.OK);
            }
        }
    }
}
