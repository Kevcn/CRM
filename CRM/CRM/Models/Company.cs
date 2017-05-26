using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual Place Place { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}