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
    public partial class frmProvider : Form
    {
        IProviderRepository providerRepository = new ProviderRepository();
        public frmProvider()
        {
            InitializeComponent();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Provider pro = null;
            try
            {
                pro = new Provider
                {
                    ProviderName = txtProviderName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                };
                providerRepository.AddProvider(pro);
                MessageBox.Show("Add successfully!!", "Add new provider", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
