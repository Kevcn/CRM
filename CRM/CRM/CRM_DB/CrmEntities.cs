using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRM.Models;

namespace CRM.CRM_DB
{
    public class CrmEntities : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Place> Places { get; set; }
    }
}