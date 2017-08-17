using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestWeb2.Database
{
    public class DBContext : DbContext
    {
        public DBContext()
    {

    }
        public DbSet<DataTable> Data { get; set; }
        public DbSet<UsersTable> Users { get; set; }
    }
}