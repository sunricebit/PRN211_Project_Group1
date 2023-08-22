
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product Product) => ProductDAO.getInstance.AddProduct(Product);
        public IEnumerable<Product> GetProductList() => ProductDAO.getInstance.GetProductList();
        public void RemoveProduct(int ProductID) => ProductDAO.getInstance.RemoveProduct(ProductID);

        public IEnumerable<Product> SearchProduct(int id) => ProductDAO.getInstance.SearchProduct(id);

        public IEnumerable<Product> SearchProduct(string name) => ProductDAO.getInstance.SearchProduct(name);

        public IEnumerable<Product> SearchProductByCat(int id) => ProductDAO.getInstance.SearchProductByCat(id);

        public IEnumerable<Product> SearchProductByProv(int id) => ProductDAO.getInstance.SearchProductByProv(id);

        public void UpdateProduct(Product Product) => ProductDAO.getInstance.UpdateProduct(Product);
    }
}
