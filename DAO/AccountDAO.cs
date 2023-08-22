using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_Group1.DAO
{
    public class AccountDao
    {
        private static readonly Lazy<AccountDao> instance = new Lazy<AccountDao>(() => new AccountDao());
        public static AccountDao Instance => instance.Value;

        private AccountDao() { }

        public Account GetAccountById(int id)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            return context.Accounts.FirstOrDefault(item => item.Id == id);
        }

        public Account GetAccountByEmail(string email)
        {
            InteriorProductManagementContext ctx = new InteriorProductManagementContext();
            return ctx.Accounts.FirstOrDefault(item => item.Email.Equals(email));
        }

        public IEnumerable<Account> GetAllAccount()
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            return context.Accounts;
        }

        public void CreateAccount(Account account)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            context.Accounts.Update(account);
            context.SaveChanges();
        }

        public void DeleteAccount(Account account)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            context.Accounts.Remove(account);
            context.SaveChanges();
        }
    }
}
