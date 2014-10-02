using System;
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
    public class ProjectUsersController : Controller
    {
        private BugSleuthEntities db = new BugSleuthEntities();

        // GET: ProjectUsers/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult AssignUsers(int id)
        {
            var project = db.Projects.Find(id);
            var model = new ProjectUsersViewModel { ProjectId = id, ProjectName = project.Name };
            List<BTUser> userProjectList = new List<BTUser>();
            foreach (var user in db.BTUsers.ToList())
            {
                if (!user.IsOnProject(id))
                {
                    userProjectList.Add(user);
                }
            }
            model.Users = new MultiSelectList(userProjectList.OrderBy(m => m.DisplayName), "UserName", "DisplayName", null);
            
            return View(model);
        }

        // POST: ProjectUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult AssignUsers(ProjectUsersViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.SelectedUsers != null)
                {
                    foreach (string username in model.SelectedUsers)
                    {
                        var user = db.BTUsers.FirstOrDefault(u => u.UserName == username);
                        user.AddUserToProject(model.ProjectId);
                    }
                }
                return RedirectToAction("Index", "Projects");
            }
            return View(model);
        }

        // GET: ProjectUsers/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult UsersOnProject(int id)
        {
            var project = db.Projects.Find(id);
            var model = new ProjectUsersViewModel { ProjectId = id, ProjectName = project.Name };
            List<BTUser> userlist = new List<BTUser>();
            foreach (var user in db.BTUsers.ToList())
            {
                if (user.IsOnProject(model.ProjectId))
                {
                    userlist.Add(user);
                }
            }
            model.Users = new MultiSelectList(userlist.OrderBy(m => m.DisplayName), "UserName", "DisplayName", null);
            return View(model);
        }

        // POST: ProjectUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult UsersOnProject(ProjectUsersViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.SelectedUsers != null)
                {
                    foreach (string username in model.SelectedUsers)
                    {
                        var user = db.BTUsers.FirstOrDefault(a => a.UserName == username);
                        user.RemoveUserFromProject(model.ProjectId);
                    }
                    return RedirectToAction("Index", "Projects");
                }
            }
            return View(model);
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
