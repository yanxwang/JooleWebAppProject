using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JooleWebApplication.Models;

namespace JooleWebApplication.Controllers
{
    public class tblProjectsController : Controller
    {
        private DatabaseEntities db = new DatabaseEntities();

        // GET: tblProjects
        public ActionResult Index()
        {
            var tblProjects = db.tblProjects.Include(t => t.tblUser);
            return View(tblProjects.ToList());
        }

        // GET: tblProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProject tblProject = db.tblProjects.Find(id);
            if (tblProject == null)
            {
                return HttpNotFound();
            }
            return View(tblProject);
        }

        // GET: tblProjects/Create
        public ActionResult Create()
        {
            ViewBag.User_id = new SelectList(db.tblUsers, "User_ID", "User_Name");
            return View();
        }

        // POST: tblProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Project_ID,Project_Name,User_id,Project_Address1,Project_Address2,Project_City,Project_State,Project_Postal_Code")] tblProject tblProject)
        {
            if (ModelState.IsValid)
            {
                db.tblProjects.Add(tblProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.User_id = new SelectList(db.tblUsers, "User_ID", "User_Name", tblProject.User_id);
            return View(tblProject);
        }

        // GET: tblProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProject tblProject = db.tblProjects.Find(id);
            if (tblProject == null)
            {
                return HttpNotFound();
            }
            ViewBag.User_id = new SelectList(db.tblUsers, "User_ID", "User_Name", tblProject.User_id);
            return View(tblProject);
        }

        // POST: tblProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Project_ID,Project_Name,User_id,Project_Address1,Project_Address2,Project_City,Project_State,Project_Postal_Code")] tblProject tblProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.User_id = new SelectList(db.tblUsers, "User_ID", "User_Name", tblProject.User_id);
            return View(tblProject);
        }

        // GET: tblProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProject tblProject = db.tblProjects.Find(id);
            if (tblProject == null)
            {
                return HttpNotFound();
            }
            return View(tblProject);
        }

        // POST: tblProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblProject tblProject = db.tblProjects.Find(id);
            db.tblProjects.Remove(tblProject);
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
