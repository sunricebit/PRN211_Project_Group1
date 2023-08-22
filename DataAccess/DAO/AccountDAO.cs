
using PRN211_Project_Group1.DataAccess;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace DataAccess
{
    public class AccountDAO
    {
        //Using singleton pattern
        private static AccountDAO instance = null;
        private static object instanceLock = new object();
        public static AccountDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Account> GetAccountList()
        {
            var list = new List<Account>();
            try
            {
                using var context = new InteriorProductManagementContext();
                list = context.Accounts.ToList();//Take Account entries and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return list;
        }
        public Account GetAccount(int id)
        {
            Account Account = null;
            try
            {
                using var context = new InteriorProductManagementContext();
                Account = context.Accounts.SingleOrDefault(m=>m.Id==id);//Take Account entries by id and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return Account;
        }
        public void AddAccount(Account Account)
        {
            try
            {
                Account mem = GetAccount(Account.Id); //Get Account entry by id
                if (mem == null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Accounts.Add(Account); //Add if not exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Account Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void UpdateAccount(Account Account) 
        {
            try
            {
                Account mem = GetAccount(Account.Id); //Get Account entry by id
                if (mem != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Accounts.Update(Account); //Update if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Account Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void RemoveAccount(int Id)
        {
            try
            {
                Account mem = GetAccount(Id); //Get Account entry by id
                if (mem != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Accounts.Remove(mem); //Delete if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Account Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public IEnumerable<Account> SearchAccount(int id)
        {
            IEnumerable<Account> result = null;
            try
            {
                using var context = new InteriorProductManagementContext();
                var search = context.Accounts.Where((Account) => Account.Id == id).ToList(); //Get all Account where Account id= search id
                result = search;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return result;
        }
        public IEnumerable<Account> SearchAccount(string usname)
        {
            IEnumerable<Account> result = null;
            try
            {
                using var context = new InteriorProductManagementContext();
                var search = context.Accounts.Where((Account) => Account.Username.ToLower() == usname.ToLower()).ToList();// Same but with company name instead
                result = search;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return result;
        }
        public IEnumerable<Account> SearchAccountName(string fullname)
        {
            IEnumerable<Account> result = null;
            try
            {
                using var context = new InteriorProductManagementContext();
                var search = context.Accounts.Where((Account) => Account.FullName.ToLower() == fullname.ToLower()).ToList();// Same but with company name instead
                result = search;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return result;
        }
    }//end AccountDAO
}