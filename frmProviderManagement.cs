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

namespace Project
{
    public partial class frmProviderManagement : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        ProviderRepository repository = new ProviderRepository();
        public Account account { get; set; }
        frmLogin frm;
        public frmProviderManagement(Account acc, frmLogin frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.account = acc;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void frmProviderManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
