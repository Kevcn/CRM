using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CrmModels;

namespace CrmDatabaseManagement
{
    public class CrmEntities : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}