using BusinessObject.BusinessObject;
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        //Using singleton pattern
        private static ProductDAO instance = null;
        private static object instanceLock = new object();
        public static ProductDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetProductList()
        {
            var list = new List<Product>();
            try
            {
                using var context = new InteriorProductManagementContext();//New DBContext instance
                list = context.Products.ToList();//Take Product entries and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return list;
        }
        public Product GetProduct(int id)
        {
            Product Product = null;
            try
            {
                using var context = new InteriorProductManagementContext();//New DBContext instance
                Product = context.Products.SingleOrDefault(m => m.Id == id);//Take Product entries by id and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return Product;
        }
        public void AddProduct(Product Product)
        {
            try
            {
                Product pro = GetProduct(Product.Id); //Get Product entry by id
                if (pro == null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Products.Add(Product); //Add if not exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Product Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void UpdateProduct(Product Product)
        {
            try
            {
                Product pro = GetProduct(Product.Id); //Get Product entry by id
                if (pro != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Products.Update(Product); //Update if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Product Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void RemoveProduct(int productid)
        {
            try
            {
                Product pro = GetProduct(productid); //Get Product entry by id
                if (pro != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Products.Remove(pro); //Delete if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Product Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public IEnumerable<Product> SearchProduct(int id)
        {
            using var context = new InteriorProductManagementContext();
            return context.Products.Where(Product => Product.Id == id).ToList(); //Get all Products where Product id= search id
        }
        public IEnumerable<Product> SearchProductByCat(int id)
        {
            using var context = new InteriorProductManagementContext();
            return context.Products.Where(Product => Product.CategoryId == id).ToList(); //Get all Products where Product id= search id
        }
        public IEnumerable<Product> SearchProductByProv(int id)
        {
            using var context = new InteriorProductManagementContext();
            return context.Products.Where(Product => Product.ProviderId == id).ToList(); //Get all Products where Product id= search id
        }
        public IEnumerable<Product> SearchProduct(string proname)
        {
            using var context = new InteriorProductManagementContext();
            return context.Products.Where(Product => Product.ProductName.ToLower() == proname.ToLower()).ToList();// Same but with product name instead
        }     
    }
}
