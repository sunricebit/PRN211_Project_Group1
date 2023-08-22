
using DataAccess;
using PRN211_Project_Group1.DataAccess;

namespace NES_Store
{
    public partial class ResetPassword : Form
    {
        InteriorProductManagementContext context = new InteriorProductManagementContext();
        public Account Account { get; set; }
        AccountRepository AccountRepository = new AccountRepository();
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text;
            var account = context.Accounts.FirstOrDefault(a => a.Email == email);
            if (account != null)
            {
                gbPass.Enabled = true;
                lbcheck.Text = "User found!";
                lbcheck.ForeColor = Color.Green;
                this.Account = account;
            }
            else
            {
                lbconfirm.Text = "";
                txtConfirmPass.Clear();
                txtNewPass.Clear();
                gbPass.Enabled = false;
                lbcheck.Text = "User not found!";
                lbcheck.ForeColor = Color.Red;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pass = txtNewPass.Text;
            string cpass = txtConfirmPass.Text;
            if (pass.Equals(cpass))
            {
                Account.Password = pass;
                AccountRepository.UpdateAccount(Account);
                lbconfirm.Text = "Save success!";
                lbconfirm.ForeColor = Color.Green;
            }
            else
            {
                lbconfirm.Text = "Password not match!";
                lbconfirm.ForeColor = Color.Red;
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            gbPass.Enabled = false;
        }
    }
}
