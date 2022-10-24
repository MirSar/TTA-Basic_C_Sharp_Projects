using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }

            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }

            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        // add logic to calculate a quote based on given guidelines: 
        public ActionResult Admin (int id)
        {
            // Find Insuree
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            // Calculate the Age of the Insuree
            TimeSpan ageOfInsuree = DateTime.Now - insuree.DateOfBirth;
            // Convert to days as int
            int ageNow = ageOfInsuree.Days;

            // start with a base of $50 / month.
            Double monthlyTotal = 50.00;

            //if the user is 18 or under, add $100 to the monthly total.
            if (ageNow < (19 * 365))
            {
                monthlyTotal += 100;
            }
            // If the user is from 19 to 25, add $50 to the monthly total.
            else if (ageNow>=(19*365) && ageNow < (26 * 365))
            {
                monthlyTotal += 50;
            }
            // If the user is 26 or older, add $25 to the monthly total. 
            else if (ageNow>= (26 * 365))
            {
                monthlyTotal += 25;
            }

            // If the car's year is before 2000, add $25 to the monthly total.
            // If the car's year is after 2015, add $25 to the monthly total.
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                monthlyTotal += 25;
            }

            // For Car's Make
            string carMake = insuree.CarMake.ToLower();
            // If the car's Make is a Porsche, add $25 to the price.
            if (carMake == "porsche")
            {
                monthlyTotal += 25;
            }
            // If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
            string carModel = insuree.CarModel.ToLower();
            if (carMake == "porsche" && carModel =="911")
            {
                monthlyTotal += 25;
            }
            // Add $10 to the monthly total for every speeding ticket the user has.
            if (insuree.SpeedingTickets > 0)
            {
                monthlyTotal += insuree.SpeedingTickets * 10;
            }
            // If the user has ever had a DUI, add 25% to the total.
            if (insuree.DUI)
            {
                monthlyTotal += monthlyTotal * .25;
            }
            // If it's full coverage, add 50% to the total.
            if (insuree.CoverageType)
            {
                monthlyTotal += monthlyTotal * .5;
            }

            return View(insuree);
        }


    }
}
