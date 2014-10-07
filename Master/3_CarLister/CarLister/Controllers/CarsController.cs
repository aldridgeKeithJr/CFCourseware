using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO; // required for uploading the image file
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
        private CarListerEntities db = new CarListerEntities();

        // GET: Cars1
        public ActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        // GET: Cars1
        public ActionResult Index_Simple()
        {
            return View(db.Cars.ToList());
        }

        // GET: Cars1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars1/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Cars1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Year,Make,Model,PicUrl,Value,Path,CategoryId,Description")] Car car, HttpPostedFileBase fileUpload)
        {
            if (ModelState.IsValid)
            {
                if (fileUpload != null && fileUpload.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(fileUpload.FileName);
                    car.Path = Path.Combine(Server.MapPath("~/img/"), fileName);
                    fileUpload.SaveAs(car.Path);
                    car.PicUrl = "~/img/" + fileName;
                }
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", car.CategoryId);
            return View(car);
        }

        // GET: Cars1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", car.CategoryId);
            return View(car);
        }

        // POST: Cars1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Year,Make,Model,PicUrl,Value,Path,CategoryId,Description")] Car car, HttpPostedFileBase fileUpload)
        {
            if (ModelState.IsValid)
            {
                if (fileUpload != null && fileUpload.ContentLength > 0)
                {
                    System.IO.File.Delete(car.Path);
                    var fileName = Path.GetFileName(fileUpload.FileName);
                    car.Path = Path.Combine(Server.MapPath("~/img/"), fileName);
                    fileUpload.SaveAs(car.Path);
                    car.PicUrl = "~/img/" + fileName;
                }
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", car.CategoryId);
            return View(car);
        }

        // GET: Cars1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            System.IO.File.Delete(car.Path); 
            db.Cars.Remove(car);
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
