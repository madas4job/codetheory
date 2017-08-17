using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb2.Database
{
    public class DataQuery
    {
        private static DataQuery inst = null;
        public static DataQuery GetInstance()
        {
            if(inst == null)
            {
                inst = new DataQuery();
            }
            return inst;
        }

        public IQueryable<data> GetData(string userId, DateTime date)
        {
            IQueryable < data > info = null;
            using (var context = new testwebdbEntities())
            {
                var userQuery = context.users1.Where(s => s.Userid == userId);

                var userinfo = userQuery.FirstOrDefault<users>();
                if (null != userinfo)
                {
                    var dataQuery = context.data1.Where(s => s.userid == userinfo.Id && s.date == date);
                    info = dataQuery;
                }
            }
            return info;
        }

        public bool AddData(string userId, int glucose, DateTime date)
        {
            IQueryable<data> dataInfo = GetData(userId, date);
            if(dataInfo.Count() < 4)
            {
                using (var context = new testwebdbEntities())
                {
                    var userQuery = context.users1.Where(s => s.Userid == userId);
                    var userinfo = userQuery.FirstOrDefault<users>();
                    if (null != userinfo)
                    {
                        data info = new data();
                        info.date = date;
                        info.glucose = glucose;
                        info.userid = userinfo.Id;
                        context.data1.Add(info);
                        return true;
                    }
                }
            }
            return false;
        }

        public IQueryable<data> GetAllData(string userid)
        {
            IQueryable<data> info = null;
            using (var context = new testwebdbEntities())
            {
                var userQuery = context.users1.Where(s => s.Userid == userid);

                var userinfo = userQuery.FirstOrDefault<users>();
                if (null != userinfo)
                {
                    var dataQuery = context.data1.Where(s => s.userid == userinfo.Id);
                    info = dataQuery;
                }
            }
            return info;
        }
    }
}