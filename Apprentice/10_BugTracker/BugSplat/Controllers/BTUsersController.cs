/*using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BugSleuth.Models;

namespace BugSleuth.Controllers
{
    public class BTUsersController : Controller
    {
        private BugSleuthEntities db = new BugSleuthEntities();


        // GET: BTUsers
        [Authorize(Roles = "Administrator")]
        public ActionResult ListUsers()
        {
            return View();
        }

        // GET: BTUsers/Edit/5
        //[Authorize(Roles = "Administrator")]
        public ActionResult EditUser(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }

        // POST: BTUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult EditUser(BTUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: BTUsers/Delete/5
        //[Authorize(Roles="Administrator")]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }

        // POST: BTUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        //[Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {

            return RedirectToAction("Index");
        }

        
        
        // GET: BTUsers
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            return View(db.BTUsers.ToList().OrderBy(u => u.DisplayName));
        }

        // GET: BTUsers/Edit/5
        //[Authorize(Roles = "Administrator")]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BTUser bTUser = db.BTUsers.FirstOrDefault(u => u.AspNetUserId == id);
            if (bTUser == null)
            {
                return HttpNotFound();
            }
            return View(bTUser);
        }

        // POST: BTUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserName,FirstName,LastName,DisplayName,AspNetUserId")] BTUser bTUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bTUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bTUser);
        }

        // GET: BTUsers/Delete/5
        //[Authorize(Roles="Administrator")]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BTUser bTUser = db.BTUsers.FirstOrDefault(u => u.AspNetUserId == id);
            if (bTUser == null)
            {
                return HttpNotFound();
            }
            return View(bTUser);
        }

        // POST: BTUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        //[Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BTUser bTUser = db.BTUsers.FirstOrDefault(u => u.AspNetUserId == id);
            db.BTUsers.Remove(bTUser);
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
*/