


using PRN211_Project_Group1.DataAccess;

namespace DataAccess
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> GetAccountList();
        public void AddAccount(Account Account);
        public void UpdateAccount(Account Account);
        public void RemoveAccount(int AccountID);
        public IEnumerable<Account> SearchAccount(int id);
        public IEnumerable<Account> SearchAccount(string usname);
        public IEnumerable<Account> SearchAccountName(string usname);
    }
}
