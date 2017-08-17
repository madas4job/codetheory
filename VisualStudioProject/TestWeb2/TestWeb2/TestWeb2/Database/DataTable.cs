using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestWeb2.Database
{
    public class DataTable
    {
        public long Id { get; set; }
        public int glucose { get; set; }
        public DateTime date { get; set; }
        public long userid { get; set; }
    }

    public class UsersTable
    {
        public long Id { get; set; }
        public string userid { get; set; }
    }
}