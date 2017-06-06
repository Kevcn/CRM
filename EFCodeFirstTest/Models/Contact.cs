using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrmModels
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage= "Contact name is required.")]
        public string Name { get; set; }

        public string Position { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Favorite { get; set; }

        [Display(Name="Company")]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

       


    }
}