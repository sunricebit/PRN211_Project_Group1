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
    public partial class frmCategoryManagement : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        CategoryRepository repository = new CategoryRepository();
        public Account account { get; set; }
        frmLogin frm;
        public frmCategoryManagement(Account acc, frmLogin Login)
        {
            InitializeComponent();
            this.account = acc;
            this.frm = Login;
        }

        private void frmCategoryManagement_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
