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

namespace FurnitureWinApp
{
    public partial class frmAccountManagement : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        AccountRepository accountRepository = new AccountRepository();
        public Account account { get; set; }
        frmLogin frm;
        public frmAccountManagement(Account acc, frmLogin login)
        {
            InitializeComponent();
            this.account = acc;
            this.frm = login;
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
