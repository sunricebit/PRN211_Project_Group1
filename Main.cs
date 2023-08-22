using FurnitureWinApp;
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

namespace PRN211_Project_Group1
{
    public partial class Main : Form
    {
        public Account account1 { get; set; }
        public frmLogin frm;
        public Main(frmLogin frmLogin, Account account)
        {
            InitializeComponent();
            this.account1 = account;
            this.frm = frmLogin;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProductManagement frmProductManagement = new frmProductManagement(account1, frm);
            frmProductManagement.Show();
            this.Close();
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            frmProviderManagement form = new frmProviderManagement(account1, frm);
            form.Show();
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategoryManagement form = new frmCategoryManagement(account1, frm);
            form.Show();
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory form = new frmHistory();
            form.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAccountManagement form = new frmAccountManagement(account1, frm);
            form.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelname.Text = $"Welcome, {account1.FullName}! Please choose what you want to do.";

            if (!account1.Role.Equals("Admin"))
            {
                btnAdmin.Enabled = false;
            }
            else
            {
                grOther.Enabled = false;
            }
        }
    }
}
