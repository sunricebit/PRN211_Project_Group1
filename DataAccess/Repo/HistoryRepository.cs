
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HistoryRepository : IHistoryRepository
    {
        public void AddHistory(History member) => HistoryDAO.getInstance.AddHistory(member);

        public IEnumerable<History> GetHistoryList() => HistoryDAO.getInstance.GetHistoryList();

    }
}
