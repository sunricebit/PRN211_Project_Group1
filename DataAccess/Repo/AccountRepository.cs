
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        public void AddAccount(Account member) => AccountDAO.getInstance.AddAccount(member);

        public IEnumerable<Account> GetAccountList() => AccountDAO.getInstance.GetAccountList();

        public void RemoveAccount(int AccountID) => AccountDAO.getInstance.RemoveAccount(AccountID);

        public IEnumerable<Account> SearchAccount(int id)
        {
            return AccountDAO.getInstance.SearchAccount(id);
        }

        public IEnumerable<Account> SearchAccount(string comname)
        {
            return AccountDAO.getInstance.SearchAccount(comname);
        }

        public IEnumerable<Account> SearchAccountName(string usname)
        {
            return AccountDAO.getInstance.SearchAccountName(usname);
        }

        public void UpdateAccount(Account member) => AccountDAO.getInstance.UpdateAccount(member);
    }
}
