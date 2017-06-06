﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Postion { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Favorite { get; set; }

        public virtual Company Company { get; set; }
    }
}