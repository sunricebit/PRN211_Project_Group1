
using PRN211_Project_Group1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HistoryDAO
    {
        //Using singleton pattern
        private static HistoryDAO instance = null;
        private static object instanceLock = new object();
        public static HistoryDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HistoryDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<History> GetHistoryList()
        {
            var list = new List<History>();
            try
            {
                using var context = new InteriorProductManagementContext();//New DBContext instance
                list = context.Histories.ToList();//Take History entries and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return list;
        }
        public History GetHistory(int id)
        {
            History History = null;
            try
            {
                using var context = new InteriorProductManagementContext();//New DBContext instance
                History = context.Histories.SingleOrDefault(m => m.Id == id);//Take History entries by id and turn them into list
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return History;
        }
        public void AddHistory(History History)
        {
            try
            {
                History pro = GetHistory(History.Id); //Get History entry by id
                if (pro == null) //Check if existed
                {
                    using var context = new InteriorProductManagementContext();
                    context.Histories.Add(History); //Add if not exist
                    context.SaveChanges();//Save changes to database
                }
                else throw new Exception("History Exist.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        
    }
}
