using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_Group1.DAO
{
    public class ProductDao
    {
        private static readonly Lazy<ProductDao> instance = new Lazy<ProductDao>(() => new ProductDao());
        public static ProductDao Instance => instance.Value;

        private ProductDao() { }

        public Product GetProductById(int id)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            return context.Products.FirstOrDefault(item => item.Id == id);
        }

        public Product GetProductByName(string name)
        {
            InteriorProductManagementContext ctx = new InteriorProductManagementContext();
            return ctx.Products.FirstOrDefault(item => item.ProductName.Equals(name));
        }

        public IEnumerable<Product> GetListProductByName(string name)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            return context.Products.Where(item => item.ProductName.Contains(name));
        }

        public IEnumerable<Product> GetAllProduct()
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            return context.Products;
        }

        public void CreateProduct(Product product)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            InteriorProductManagementContext context = new InteriorProductManagementContext();
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
