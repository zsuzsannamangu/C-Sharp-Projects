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
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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

        //add logic to calculate a quote
        public ActionResult Admin(int Id, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool dUI, int speedingTickets, bool coverageType)
        {
                decimal quote = 50.00M;
            
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            int age = currentYear - Convert.ToDateTime(dateOfBirth).Year;

            if (currentDate.Month < Convert.ToDateTime(dateOfBirth).Month || (currentDate.Month == Convert.ToDateTime(dateOfBirth).Month && currentDate.Day < Convert.ToDateTime(dateOfBirth).Day))
                age--;
            
            quote = (age <= 18) ? + 100.00M : quote; //(condition) ? [true path] : [false path];
            quote = (age > 19 && age < 25) ? + 50.00M : quote;
            quote = (age > 26) ? + 25.00M : quote;

            quote = (Convert.ToInt32(carYear) < 2000 || Convert.ToInt32(carYear) > 2015) ? + 25.00M : quote;
            quote = (carMake.ToLower() == "Porsche" && carModel.ToLower() != "911 Carrera") ? + 25.00M : quote;
            quote = (carMake.ToLower() == "Porsche" && carModel.ToLower().Contains("carrera")) ? + 50.00M : quote;

            quote = (Convert.ToInt32(speedingTickets) > 0) ? + Convert.ToDecimal(Convert.ToInt32(quote) * Convert.ToInt32(speedingTickets) * 10) : quote;
            quote = (dUI == true) ? quote + (Decimal.Multiply(quote, .25M)) : quote;
            quote = (coverageType == true) ? quote + (Decimal.Multiply(quote, .50M)) : quote;

            return View(quote);

            using (InsuranceEntities db = new InsuranceEntities())
            {
                var table = new Table();
                table.Quote = quote;
                db.Tables.Add(table);
                db.SaveChanges();
            }
        }

    }
}
