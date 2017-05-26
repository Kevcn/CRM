using EFCodeFirstTest.DB_Connection;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstTest.Controllers
{
    public class CrmController : Controller
    {
        CrmEntities db = new CrmEntities();

        // GET: Crm
        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }
        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Contacts.Add(contact);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(contact);
            }
            catch
            {

                return View();
            }
        }


    }
}