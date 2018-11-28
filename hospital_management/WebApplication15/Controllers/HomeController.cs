using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AddDoctor()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddDoctor(AddDoctorviewmodel model)
        {
            try
            {
                hospital_managementEntities db = new hospital_managementEntities();
                 Register d = new Register();
                 d.email = model.Email;
                 d.password = model.Password;
                 d.question = model.Question;
                 d.answer = model.Answer;
                 d.type = "Doctor";
                 db.Registers.Add(d);
                db.SaveChanges();
                foreach (Register R in db.Registers)
                 {
                     if (R.email == model.Email && R.password == model.Password)
                     {
                        History_doctor h = new History_doctor();
                         h.register_id = R.id;
                         h.name = model.Name;
                         h.category = model.Category;
                         h.email = model.Email;
                         db.History_doctor.Add(h);
                     }
                 }
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            }
            catch(Exception e)
            {

                return View();
            }
            return View();
        }
    }
}