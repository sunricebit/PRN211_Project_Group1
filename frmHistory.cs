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
    public partial class frmHistory : Form
    {
        IHistoryRepository repository = new HistoryRepository();
        BindingSource source = new BindingSource();
        IEnumerable<History> DataSource;
        public frmHistory()
        {
            InitializeComponent();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            var history = repository.GetHistoryList();
            try
            {
                source.DataSource = history;
                dgvHistory.DataSource = null;
                dgvHistory.DataSource = source;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
