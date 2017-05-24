using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRM.Models;

namespace CRM.Data
{
    public class ContactRepository
    {

        //Connection to DB?

        private List<Contact> contacts = new List<Contact>();


        public Contact getContact(string name)
        {
            Contact contactToReturn = null;

            // if contacts.substring == name,
            // contactToReturn = thatConact


            return contactToReturn;
        }


        public List<Contact> getAllContact()
        {
            return contacts;
        }

    }
}