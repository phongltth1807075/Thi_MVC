using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Thi_.Net.Models;

namespace Thi_.Net.Controllers
{
    public class SubJectsController : Controller
    {
        private Context db = new Context();

        // GET: SubJects
        public ActionResult Index()
        {
            return View(db.SubJects.ToList());
        }

        // GET: SubJects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubJect subJect = db.SubJects.Find(id);
            if (subJect == null)
            {
                return HttpNotFound();
            }
            return View(subJect);
        }

        // GET: SubJects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubJects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] SubJect subJect)
        {
            if (ModelState.IsValid)
            {
                db.SubJects.Add(subJect);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subJect);
        }

        // GET: SubJects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubJect subJect = db.SubJects.Find(id);
            if (subJect == null)
            {
                return HttpNotFound();
            }
            return View(subJect);
        }

        // POST: SubJects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] SubJect subJect)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subJect).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subJect);
        }

        // GET: SubJects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubJect subJect = db.SubJects.Find(id);
            if (subJect == null)
            {
                return HttpNotFound();
            }
            return View(subJect);
        }

        // POST: SubJects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubJect subJect = db.SubJects.Find(id);
            db.SubJects.Remove(subJect);
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
