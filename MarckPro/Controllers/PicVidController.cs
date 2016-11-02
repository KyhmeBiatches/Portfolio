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
    public class PicVidController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PicVid
        public ActionResult Index()
        {
            return View(db.PicVidModels.ToList());
        }

        // GET: PicVid/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PicVidModels picVidModels = db.PicVidModels.Find(id);
            if (picVidModels == null)
            {
                return HttpNotFound();
            }
            return View(picVidModels);
        }

        // GET: PicVid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PicVid/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id")] PicVidModels picVidModels)
        {
            if (ModelState.IsValid)
            {
                db.PicVidModels.Add(picVidModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(picVidModels);
        }

        // GET: PicVid/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PicVidModels picVidModels = db.PicVidModels.Find(id);
            if (picVidModels == null)
            {
                return HttpNotFound();
            }
            return View(picVidModels);
        }

        // POST: PicVid/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id")] PicVidModels picVidModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(picVidModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(picVidModels);
        }

        // GET: PicVid/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PicVidModels picVidModels = db.PicVidModels.Find(id);
            if (picVidModels == null)
            {
                return HttpNotFound();
            }
            return View(picVidModels);
        }

        // POST: PicVid/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PicVidModels picVidModels = db.PicVidModels.Find(id);
            db.PicVidModels.Remove(picVidModels);
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
