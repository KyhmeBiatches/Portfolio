using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarckPro.Models;

namespace MarckPro.Controllers
{
    public class AchievedsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Achieveds
        public ActionResult Index()
        {
            return View(db.Achievements.ToList());
        }

        // GET: Achieveds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achieved achieved = db.Achievements.Find(id);
            if (achieved == null)
            {
                return HttpNotFound();
            }
            return View(achieved);
        }

        // GET: Achieveds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Achieveds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,content")] Achieved achieved)
        {
            if (ModelState.IsValid)
            {
                db.Achievements.Add(achieved);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(achieved);
        }

        // GET: Achieveds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achieved achieved = db.Achievements.Find(id);
            if (achieved == null)
            {
                return HttpNotFound();
            }
            return View(achieved);
        }

        // POST: Achieveds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,content,createdAt")] Achieved achieved)
        {
            if (ModelState.IsValid)
            {
                db.Entry(achieved).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(achieved);
        }

        // GET: Achieveds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achieved achieved = db.Achievements.Find(id);
            if (achieved == null)
            {
                return HttpNotFound();
            }
            return View(achieved);
        }

        // POST: Achieveds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Achieved achieved = db.Achievements.Find(id);
            db.Achievements.Remove(achieved);
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
