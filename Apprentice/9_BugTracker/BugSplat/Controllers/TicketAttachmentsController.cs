using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BugSleuth.Models;

namespace BugSleuth.Controllers
{
    public class TicketAttachmentsController : Controller
    {
        private BugSleuthEntities db = new BugSleuthEntities();

        // GET: TicketAttachments/Details/5
        [Authorize(Roles = "Administrator, Developer, Submitter")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketAttachment ticketAttachment = db.TicketAttachments.Find(id);
            if (ticketAttachment == null)
            {
                return HttpNotFound();
            }
            return View(ticketAttachment);
        }

        // GET: TicketAttachments/Create
        [Authorize(Roles = "Administrator, Developer, Submitter")]
        public ActionResult Create(int id)
        {
            var attachment = new TicketAttachment();
            attachment.UserName = User.Identity.Name;
            attachment.BTUser = db.BTUsers.Find(User.Identity.Name);
            attachment.TicketId = id;
            attachment.Ticket = db.Tickets.Find(id);
            attachment.Created = DateTimeOffset.Now;
            return View(attachment);
        }

        // POST: TicketAttachments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator, Developer, Submitter")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TicketId,FilePath,Description,Created,UserName")] TicketAttachment ticketAttachment, HttpPostedFileBase fileUpload)
        {
            if (ModelState.IsValid)
            {
                if (fileUpload != null && fileUpload.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(fileUpload.FileName);
                    ticketAttachment.FilePath = Path.Combine(Server.MapPath("~/img/"), fileName);
                    fileUpload.SaveAs(ticketAttachment.FilePath);
                    ticketAttachment.FileUrl = "~/img/" + fileName;
                }
                db.TicketAttachments.Add(ticketAttachment);
                db.SaveChanges();
                return RedirectToAction("Edit", "Tickets", new { id = ticketAttachment.TicketId });
            }

            return View(ticketAttachment);
        }

        // GET: TicketAttachments/Edit/5
        [Authorize(Roles = "Administrator, Developer, Submitter")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketAttachment ticketAttachment = db.TicketAttachments.Find(id);
            if (ticketAttachment == null)
            {
                return HttpNotFound();
            }
            ticketAttachment.FileUrl = ticketAttachment.FileUrl.Substring(6);
            ViewBag.UserName = new SelectList(db.BTUsers, "UserName", "FirstName", ticketAttachment.UserName);
            ViewBag.TicketId = new SelectList(db.Tickets, "Id", "Title", ticketAttachment.TicketId);
            return View(ticketAttachment);
        }

        // POST: TicketAttachments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator, Developer, Submitter")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TicketId,FilePath,Description,Created,UserName")] TicketAttachment ticketAttachment, HttpPostedFileBase fileUpload)
        {
            if (ModelState.IsValid)
            {
                if (fileUpload != null && fileUpload.ContentLength > 0)
                {
                    if (System.IO.File.Exists(ticketAttachment.FilePath))
                    {
                        System.IO.File.Delete(ticketAttachment.FilePath);
                    }
                    var fileName = Path.GetFileName(fileUpload.FileName);
                    ticketAttachment.FilePath = Path.Combine(Server.MapPath("~/img/"), fileName);
                    fileUpload.SaveAs(ticketAttachment.FilePath);
                    ticketAttachment.FileUrl = "~/img/" + fileName;
                }

                db.Entry(ticketAttachment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", "Tickets", new { id = ticketAttachment.TicketId });
            }
            ViewBag.UserName = new SelectList(db.BTUsers, "UserName", "FirstName", ticketAttachment.UserName);
            ViewBag.TicketId = new SelectList(db.Tickets, "Id", "Title", ticketAttachment.TicketId);
            return View(ticketAttachment);
        }

        // GET: TicketAttachments/Delete/5
        [Authorize(Roles = "Administrator, Developer, Submitter")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketAttachment ticketAttachment = db.TicketAttachments.Find(id);
            if (ticketAttachment == null)
            {
                return HttpNotFound();
            }
            return View(ticketAttachment);
        }

        // POST: TicketAttachments/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Administrator, Developer, Submitter")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TicketAttachment ticketAttachment = db.TicketAttachments.Find(id);
            db.TicketAttachments.Remove(ticketAttachment);
            db.SaveChanges();
            return RedirectToAction("Edit", "Tickets", new { id = ticketAttachment.TicketId });
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
