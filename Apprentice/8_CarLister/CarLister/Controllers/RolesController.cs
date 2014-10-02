using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RolesController : Controller
    {
        // create a private member variable for this controller class (you will need these throughout the controllers here) that connects to the AspNet tables (this is represented by the ApplicationDbContext object)
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Roles
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            // get a list of all roles in the DB
            var roles = db.Roles.ToList();
            // instantiate the view model as a list of RolesViewModel's
            var model = new List<RolesViewModel>();
            // loop through all the roles in the DB and add a new RolesViewModel object for each one
            foreach (var item in roles)
            {
                var r = new RolesViewModel { RoleId = item.Id, RoleName = item.Name };
                model.Add(r);
            }
            // send the model to the view
            return View(model);
        }

        // GET: Roles/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RolesViewModel model)
        {
            // check the model state, if valid, continue, otherwise return the model to the view
            if (ModelState.IsValid)
            {
                // add a new IdentityRole object using the role name in the model to the
                //  Roles table in the DB - store the return value in a var named result
                var res = db.Roles.Add(new IdentityRole(model.RoleName));
                // if the value of result is not null, save the changes and return 
                //  control to the list view (Index)
                if (res != null)
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            // if we got this far, something went wrong... return the model to the view
            return View(model);
        }

        // GET: Roles/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(string id)
        {
            // 1) locate the role and get it
            var role = db.Roles.Find(id);
            // 2) build the view model
            var model = new RolesViewModel { RoleId = id, RoleName = role.Name };
            // 3) send the model to the view
            return View(model);
        }

        // POST: Roles/Edit/5
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RolesViewModel model)
        {
            // 1) locate the role and get it
            var role = db.Roles.Find(model.RoleId);
            // 2) change the role name to match what's in the model
            role.Name = model.RoleName;
            // 3) tell the DB the role entry has been modified
            db.Entry(role).State = EntityState.Modified;
            // 4) save the changes
            db.SaveChanges();
            // 5) redirect control back to the roles list view
            return RedirectToAction("Index");
        }

        // GET: Roles/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(string id)
        {
            // 1) locate the role and get it
            var role = db.Roles.Find(id);
            // 2) build the view model
            var model = new RolesViewModel { RoleId = id, RoleName = role.Name };
            // 3) send the model to the view
            return View(model);
        }

        // POST: Roles/Delete/5
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(RolesViewModel model)
        {
            // 1) locate the role and get it
            var role = db.Roles.Find(model.RoleId);
            // 2) remove the role from the DB
            db.Roles.Remove(role);
            // 3) save your changes
            db.SaveChanges();
            // 4) redirect control back to the roles list view
            return RedirectToAction("Index");
        }
    }
}
