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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            List<string> options = new List<string> { "Admin", "Manager", "Member" };
            cboRole.DataSource = options;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Username = txtUsername.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                FullName = txtFullname.Text,
                Password = txtPassword.Text,
                Role = (string)cboRole.SelectedItem,
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
