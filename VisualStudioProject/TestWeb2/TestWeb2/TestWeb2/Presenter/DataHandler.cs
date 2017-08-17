using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWeb2.Database;

namespace TestWeb2.Presenter
{
    public class DataHandler
    {
        private static DataHandler instance = null;
        public static DataHandler GetInstance()
        {
            if(instance == null)
            {
                instance = new DataHandler();
            }
            return instance;
        }

        public bool AddGlucose(string userId, int glucose)
        {
            return DataQuery.GetInstance().AddData(userId, glucose, DateTime.Now);
        }

        public IQueryable<data> GetDetails(string userId)
        {
            return DataQuery.GetInstance().GetAllData(userId);
        }
    }
}