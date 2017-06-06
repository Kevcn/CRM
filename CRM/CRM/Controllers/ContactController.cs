using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.Data;

namespace CRM.Controllers
{
    public class ContactController : Controller
    {
        //CrmEntities db = new CrmEntities();


        // objects for access repositories. 
        private ContactRepository contactRepo = new ContactRepository();



        // GET: Contact
        public ActionResult Index()
        {

            return View(contactRepo.getAllContact());
        }

        // Display contacts on Contact home page.

        public ActionResult Contact()
        {
            var allContacts = contactRepo.getAllContact();

            return View(allContacts);
        }

        public ActionResult ContactDetail(string name)
        {
            var contact = contactRepo.getContact(name);

            return View(contact);
        }

    }
}