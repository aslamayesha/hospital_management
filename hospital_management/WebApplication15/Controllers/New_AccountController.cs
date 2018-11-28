using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    [Authorize]
    public class New_AccountController : Controller
    {
        // GET: New_Account
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Main_login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Main_login(Registerviewmodel model)
        {
            try
            {
                hospital_managementEntities db = new hospital_managementEntities();
                foreach (Register R in db.Registers)
                {
                    if (R.password == model.Password && R.email == model.Email && R.type == model.type)
                    {
                        if (model.type == "Admin")
                        {
                            return RedirectToAction("AddDoctor", "Home");
                        }
                        if (model.type == "Doctor")
                        {
                            return RedirectToAction("Addprescription", "Doctor");
                        }
                        if (model.type == "patient")
                        {
                            return RedirectToAction("MakeAppointment", "Patient");
                        }
                    }
                   
                }
            }
            catch (Exception e)
            {
                return View();
            }
            return View();

            
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(Registerviewmodel model)
        {
            try
            {
                Register R = new Register();
                R.answer = model.Answer;
                R.email = model.Email;
                R.password = model.Password;
                R.question = model.Question;
                R.type = "patient";

                hospital_managementEntities db = new hospital_managementEntities();
                db.Registers.Add(R);
                db.SaveChanges();
                return RedirectToAction("MakeAppointment","Patient");
            }
            catch (Exception e)
            {
                return View();
            }
            
        }
    }
}