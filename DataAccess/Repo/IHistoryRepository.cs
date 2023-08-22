


using PRN211_Project_Group1.DataAccess;

namespace DataAccess
{
    public interface IHistoryRepository
    {
        public IEnumerable<History> GetHistoryList();
        public void AddHistory(History History);

    }
}
