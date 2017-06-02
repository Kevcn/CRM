using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrmModels
{
    public class Company
    {
        
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Company")]
        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

    }
}