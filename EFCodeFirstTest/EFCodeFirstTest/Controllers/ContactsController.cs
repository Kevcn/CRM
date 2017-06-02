using CrmRepository;
using CrmModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstTest.Controllers
{
    public class ContactsController : Controller
    {
        ContactRepository _contactRepo;
        CompanyRepository _companyRepo;

        public ContactsController()
        {
            _contactRepo = new ContactRepository();
            _companyRepo = new CompanyRepository();
        }

        public ActionResult Index()
        {
            return View(_contactRepo.GetAll());
        }
        

        //Navigate to add contact page. 
        public ActionResult Add()
        {
            SelectListItems();

            return View();
        }

        [HttpPost]
        public ActionResult Add(Contact contact)
        {
            
                if (ModelState.IsValid)
                {
                    //update database
                    _contactRepo.Add(contact);

                    TempData["Message"] = "Contact was successfully added!";
                    //redirect back to contacts page
                    return RedirectToAction("Index");
                }

                SelectListItems();
                // show user their attempted values
                return View(contact);
            
        }

       
        
        // nullable id
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            Contact contact = _contactRepo.Find((int)id);

            if (contact == null)
                return HttpNotFound();

            return View(contact);
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            //delete contact from database
            _contactRepo.Delete(id);
            TempData["Message"] = "Contact was successfully deleted!";

            //redirect back to contact management home page
            return RedirectToAction("Index");
        }


        //Navigate to the update contact page
        public ActionResult Update(int? id)
        {
            // find the relevant contact from the database
            Contact contact = _contactRepo.Find((int)id);

            // popluate the fields with current details 
            return View(contact);
        }


        [HttpPost]
        public ActionResult Update(Contact contact, int id)
        {
            if (ModelState.IsValid)
            {
                _contactRepo.Update(contact, id);

                TempData["Message"] = "Contact was successfully updated!";

                return RedirectToAction("Index");
            }

            return View(contact);
        }

        public ActionResult Details(int? id)
        {
            Contact contact = _contactRepo.Find((int)id);

            return View(contact);
        }


        // get all companies from database
        private void SelectListItems()
        {
            ViewBag.companies = new SelectList(_companyRepo.GetAll(), "Name", "Name");
        }



    }
}