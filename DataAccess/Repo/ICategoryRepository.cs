


using PRN211_Project_Group1.DataAccess;

namespace DataAccess
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategoryList();
        public void AddCategory(Category Category);
        public void UpdateCategory(Category Category);
        public void RemoveCategory(int CategoryID);
        public IEnumerable<Category> SearchCategory(int id);
        public IEnumerable<Category> SearchCategory(string name);
    }
}
