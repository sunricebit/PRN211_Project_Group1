
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProductList();
        public void AddProduct(Product Product);
        public void UpdateProduct(Product Product);
        public void RemoveProduct(int ProductID);
        public IEnumerable<Product> SearchProduct(int id);
        public IEnumerable<Product> SearchProduct(string name);
        public IEnumerable<Product> SearchProductByCat(int id);
        public IEnumerable<Product> SearchProductByProv(int id);
    }
}
