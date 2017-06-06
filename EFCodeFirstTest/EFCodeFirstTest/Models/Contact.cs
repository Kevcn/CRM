using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstTest.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }

        public virtual Company Company { get; set; }

    }
}