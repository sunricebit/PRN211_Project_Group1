
using PRN211_Project_Group1.DataAccess;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace DataAccess
{
    public class CategoryDAO
    {
        //Using singleton pattern
        private static CategoryDAO instance = null;
        private static object instanceLock = new object();
        public static CategoryDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Category> GetCategoryList()
        {
            var list = new List<Category>();
            try
            {
                using var context = new InteriorProductManagementContext();
                list = context.Categories.ToList();//Take Category entries and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return list;
        }
        public Category GetCategory(int id)
        {
            Category Category = null;
            try
            {
                using var context = new InteriorProductManagementContext();
                Category = context.Categories.SingleOrDefault(m=>m.Id==id);//Take Category entries by id and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return Category;
        }
        public void AddCategory(Category Category)
        {
            try
            {
                Category mem = GetCategory(Category.Id); //Get Category entry by id
                if (mem == null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Categories.Add(Category); //Add if not exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Category Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void UpdateCategory(Category Category) 
        {
            try
            {
                Category mem = GetCategory(Category.Id); //Get Category entry by id
                if (mem != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Categories.Update(Category); //Update if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Category Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void RemoveCategory(int Id)
        {
            try
            {
                Category mem = GetCategory(Id); //Get Category entry by id
                if (mem != null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Categories.Remove(mem); //Delete if exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("Category Not Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public IEnumerable<Category> SearchCategory(int id)
        {
            IEnumerable<Category> result = null;
            try
            {
                using var context = new InteriorProductManagementContext();
                var search = context.Categories.Where((Category) => Category.Id == id).ToList(); //Get all Category where Category id= search id
                result = search;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return result;
        }
        public IEnumerable<Category> SearchCategory(string usname)
        {
            IEnumerable<Category> result = null;
            try
            {
                using var context = new InteriorProductManagementContext();
                var search = context.Categories.Where((Category) => Category.CategoryName.ToLower() == usname.ToLower()).ToList();// Same but with company name instead
                result = search;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return result;
        }
        
    }//end CategoryDAO
}