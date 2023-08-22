using DataAccess;
using NES_Store;
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

namespace PRN211_Project_Group1
{
    public partial class frmLogin : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        AccountRepository repository = new AccountRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var account = context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
            if(account != null)
            {
                Main main = new Main(this, account);
                main.Show();
                this.Hide();
            }
            else
            {
                txtPassword.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                label4.Text = "Incorect username or password";
                label4.ForeColor = Color.Red;
                label4.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            label4.Hide();
        }
    }
}
