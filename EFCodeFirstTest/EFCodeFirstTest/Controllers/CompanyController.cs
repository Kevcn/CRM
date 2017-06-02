using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrmRepository;
using CrmModels;

namespace EFCodeFirstTest.Controllers
{
    public class CompanyController : Controller
    {
        CompanyRepository _companyRepo;

        public CompanyController()
        {
            _companyRepo = new CompanyRepository();
        }


        
        public ActionResult Index()
        {
            return View(_companyRepo.GetAll());
        }

        
        public ActionResult Details(int id)
        {
            return View();
        }

        
        public ActionResult Add()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Add(Company company)
        {

            if (ModelState.IsValid)
            {
                _companyRepo.Add(company);

                TempData["Message"] = "Company was successfully added!";

                //if (Request.UrlReferrer.AbsolutePath.ToString() == "/Contact/Add")
                //{
                //    return Redirect(Request.UrlReferrer.AbsolutePath.ToString());
                //}
                //return Redirect(Request.UrlReferrer.AbsolutePath.ToString());
                return RedirectToAction("Index");
            }

            return View(company);
            
        }

        
        public ActionResult Update(int? id)
        {
            Company company = _companyRepo.Find((int)id);

            return View(company);
        }

        
        [HttpPost]
        public ActionResult Update(int id, Company company)
        {
            if (ModelState.IsValid)
            {
                _companyRepo.Update(company, id);

                TempData["Message"] = "Company was successfully updated!";

                return RedirectToAction("Index");
            }

            return View(company);
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            Company company = _companyRepo.Find((int)id);

            if (company == null)
                return HttpNotFound();

            return View(company);
        }

        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            _companyRepo.Delete(id);

            TempData["Message"] = "Company was successfully deleted!";

            return RedirectToAction("Index");
            
        }
    }
}
