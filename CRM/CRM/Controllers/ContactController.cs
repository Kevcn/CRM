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
        // objects for access repositories. 
        private ContactRepository contactRepo = null;



        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // Display contacts on Contact home page.

        public ActionResult Contact()
        {
            var allContacts = contactRepo.getAllContact();

            return View(allContacts);
        }



    }
}