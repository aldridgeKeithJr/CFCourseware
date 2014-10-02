using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    // scaffolded Cars model
    public class CarsController : Controller
    {
        private CarListerDBContext db = new CarListerDBContext();

        // GET: Cars
        public ActionResult Index()
        {
            return View(db.Cars.ToList());
        }


        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Year,Make,Model,PicUrl,BookValue")] CarViewModel carViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(carViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carViewModel);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarViewModel carViewModel = db.Cars.Find(id);
            if (carViewModel == null)
            {
                return HttpNotFound();
            }
            return View(carViewModel);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Year,Make,Model,PicUrl,BookValue")] CarViewModel carViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carViewModel);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarViewModel carViewModel = db.Cars.Find(id);
            if (carViewModel == null)
            {
                return HttpNotFound();
            }
            return View(carViewModel);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarViewModel carViewModel = db.Cars.Find(id);
            db.Cars.Remove(carViewModel);
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
    }
}
