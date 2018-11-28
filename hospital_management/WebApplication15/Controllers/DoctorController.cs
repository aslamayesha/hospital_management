using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
 
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Doctor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctor/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Doctor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Doctor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult AddHistory()
        {
            return View();
        }
        public ActionResult Addprescription()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addprescription( Addprescriptionviewmodel mod)
        {
            try
            {
                hospital_managementEntities db = new hospital_managementEntities();
                Patient_Prescription a = new Patient_Prescription();
                foreach (Register R in db.Registers)
                {
                    if (R.id == mod.PatientId)
                    {
                       a.Registerid = mod.PatientId;
                        a.Medicine = mod.Medicine;
                        a.Duration = mod.Duration;
                        a.Morning = mod.Morning;
                        a.Noon = mod.Noon;
                        a.Evening = mod.Evening;
                        db.Patient_Prescription.Add(a);
                        db.SaveChanges();
                        return RedirectToAction("AddHistory", "Doctor");


                    }
                }
            }
            catch (Exception e) { return View(); }
            return View();
        }


        public ActionResult checkdetails()
        {
            return View();
        }
    }
}
