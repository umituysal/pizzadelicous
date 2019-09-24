using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pizza.MvcWebUI.Entity;

namespace Pizza.MvcWebUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class GaleryController : Controller
    {
        private DataContext db = new DataContext();

        // GET: galery
        public ActionResult Index()
        {
            return View(db.Galeries.ToList());
        }

        // GET: galery/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galery galery = db.Galeries.Find(id);
            if (galery == null)
            {
                return HttpNotFound();
            }
            return View(galery);
        }

        // GET: galery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: galery/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Image")] Galery galery)
        {
            if (ModelState.IsValid)
            {
                db.Galeries.Add(galery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(galery);
        }

        // GET: galery/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galery galery = db.Galeries.Find(id);
            if (galery == null)
            {
                return HttpNotFound();
            }
            return View(galery);
        }

        // POST: galery/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Image")] Galery galery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(galery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(galery);
        }

        // GET: galery/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galery galery = db.Galeries.Find(id);
            if (galery == null)
            {
                return HttpNotFound();
            }
            return View(galery);
        }

        // POST: galery/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Galery galery = db.Galeries.Find(id);
            db.Galeries.Remove(galery);
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
