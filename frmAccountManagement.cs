using DataAccess;
using PRN211_Project_Group1.DataAccess;
using PRN211_Project_Group1;
using System.ComponentModel;

namespace FurnitureWinApp
{
    public partial class frmAccountManagement : Form
    {
        AccountRepository accountRepository = new AccountRepository();

        public frmAccountManagement(Account acc, frmLogin login)
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            List<string> options = new List<string> { "Admin", "Manager", "Member" };
            List<int> ids = new List<int>();
            cboRole.DataSource = options;
            cboSelectRole.DataSource = options;
            BindingList<Account> accounts = new BindingList<Account>();
            foreach(var account in accountRepository.GetAccountList())
            {
                accounts.Add(account);
                ids.Add(account.Id);
            }
            cboId.DataSource = ids;
            dgvAccount.DataSource = accounts;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingList<Account> accounts = new BindingList<Account>();
            if (rbFullname.Checked)
            {
                string fullName = txtSearch.Text;
                var result = accountRepository.SearchAccountName(fullName);
                foreach (var account in result)
                {
                    accounts.Add(account);
                }
            }

            if (rbID.Checked)
            {
                try
                {
                    int id = int.Parse(txtSearch.Text);
                    var result = accountRepository.SearchAccount(id);
                    foreach (var account in result)
                    {
                        accounts.Add(account);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter positive integer number");
                }
            }

            if (rbUserName.Checked)
            {
                string userName = txtSearch.Text;
                var result = accountRepository.SearchAccount(userName);
                foreach (var account in result)
                {
                    accounts.Add(account);
                }
            }

            dgvAccount.DataSource = accounts;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAccount frmAccount = new frmAccount();
            frmAccount.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)cboId.SelectedItem;
            accountRepository.RemoveAccount(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account p = new Account()
            {
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                FullName = txtFullname.Text,
                Id = (int)cboId.SelectedItem,
                Password = txtPassword.Text,
                Phone = txtPassword.Text,
                Role = cboSelectRole.Text,
            };
            accountRepository.UpdateAccount(p);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = String.Empty;
            txtFullname.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtSearch.Text = String.Empty;
            txtUsername.Text = String.Empty;
            LoadForm();
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<Account> accounts = (BindingList<Account>)dgvAccount.DataSource;
            string role = (string)cboRole.SelectedItem;
            BindingList<Account> acc = new BindingList<Account>();
            foreach (var account in accounts.Where(item => item.Role.Equals(role)))
            {
                acc.Add(account);
            };
            dgvAccount.DataSource = acc;
        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cboId.SelectedItem;
            Account account = new Account()
            {
                Id = id,
                Email = txtEmail.Text,
                FullName = txtFullname.Text,
                Password = txtPassword.Text,
                Phone = txtPhone.Text,
                Username = txtUsername.Text,
                Role = (string)cboRole.SelectedItem,
            };
            accountRepository.UpdateAccount(account);
        }
    }
}
