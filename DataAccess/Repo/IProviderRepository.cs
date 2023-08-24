
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IProviderRepository
    {
        public IEnumerable<Provider> GetProviderList();
        public void AddProvider(Provider Provider);
        public void UpdateProvider(Provider Provider);
        public void RemoveProvider(int ProviderID);
        public Provider GetProvider(int id);
        public IEnumerable<Provider> SearchProvider(int id);
        public IEnumerable<Provider> SearchProvider(string name);
    }
}
