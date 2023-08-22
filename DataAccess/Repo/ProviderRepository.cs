
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProviderRepository : IProviderRepository
    {
        public void AddProvider(Provider Provider) => ProviderDAO.getInstance.AddProvider(Provider);
        public IEnumerable<Provider> GetProviderList() => ProviderDAO.getInstance.GetProviderList();
        public void RemoveProvider(int ProviderID) => ProviderDAO.getInstance.RemoveProvider(ProviderID);

        public IEnumerable<Provider> SearchProvider(int id) => ProviderDAO.getInstance.SearchProvider(id);

        public IEnumerable<Provider> SearchProvider(string name) => ProviderDAO.getInstance.SearchProvider(name);
        public void UpdateProvider(Provider Provider) => ProviderDAO.getInstance.UpdateProvider(Provider);
    }
}
