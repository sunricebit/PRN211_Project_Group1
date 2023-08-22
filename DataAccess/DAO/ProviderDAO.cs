
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProviderDAO
    {
        //Using singleton pattern
        private static ProviderDAO instance = null;
        private static object instanceLock = new object();
        public static ProviderDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProviderDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Provider> GetProviderList()
        {
            var list = new List<Provider>();
            try
            {
                using var context = new InteriorProductManagementContext();//New DBContext instance
                list = context.Providers.ToList();//Take Provider entries and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return list;
        }
        public Provider GetProvider(int id)
        {
            Provider Provider = null;
            try
            {
                using var context = new InteriorProductManagementContext();//New DBContext instance
                Provider = context.Providers.SingleOrDefault(m => m.Id == id);//Take Provider entries by id and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return Provider;
        }
        public void AddProvider(Provider Provider)
        {
            try
            {
                Provider pro = GetProvider(Provider.Id); //Get Provider entry by id
                if (pro == null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Providers.Add(Provider); //Add if not exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Provider Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void UpdateProvider(Provider Provider)
        {
            try
            {
                Provider pro = GetProvider(Provider.Id); //Get Provider entry by id
                if (pro != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Providers.Update(Provider); //Update if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Provider Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void RemoveProvider(int productid)
        {
            try
            {
                Provider pro = GetProvider(productid); //Get Provider entry by id
                if (pro != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Providers.Remove(pro); //Delete if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Provider Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public IEnumerable<Provider> SearchProvider(int id)
        {
            using var context = new InteriorProductManagementContext();
            return context.Providers.Where(Provider => Provider.Id == id).ToList(); //Get all Providers where Provider id= search id
        }       
        public IEnumerable<Provider> SearchProvider(string proname)
        {
            using var context = new InteriorProductManagementContext();
            return context.Providers.Where(Provider => Provider.ProviderName.ToLower() == proname.ToLower()).ToList();// Same but with product name instead
        }     
    }
}
