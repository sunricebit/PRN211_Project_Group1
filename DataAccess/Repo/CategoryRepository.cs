
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category member) => CategoryDAO.getInstance.AddCategory(member);

        public IEnumerable<Category> GetCategoryList() => CategoryDAO.getInstance.GetCategoryList();

        public void RemoveCategory(int CategoryID) => CategoryDAO.getInstance.RemoveCategory(CategoryID);

        public IEnumerable<Category> SearchCategory(int id)
        {
            return CategoryDAO.getInstance.SearchCategory(id);
        }

        public Category GetCategory(int ProductID) => CategoryDAO.getInstance.GetCategory(ProductID);

        public IEnumerable<Category> SearchCategory(string name)
        {
            return CategoryDAO.getInstance.SearchCategory(name);
        }
        public void UpdateCategory(Category member) => CategoryDAO.getInstance.UpdateCategory(member);
    }
}
