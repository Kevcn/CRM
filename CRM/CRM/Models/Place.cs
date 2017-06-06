using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class Place
    {
        public int PlaceId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}