using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CineplexService.Models;

namespace CineplexService.Controllers
{
    public class HomeController : Controller
    {
        private CineplexServiceContext db = new CineplexServiceContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Movie30022962.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie30022962 movie30022962 = db.Movie30022962.Find(id);
            if (movie30022962 == null)
            {
                return HttpNotFound();
            }
            return View(movie30022962);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,Name,Duration,Genre,Rating,Price,Description")] Movie30022962 movie30022962)
        {
            if (ModelState.IsValid)
            {
                db.Movie30022962.Add(movie30022962);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie30022962);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie30022962 movie30022962 = db.Movie30022962.Find(id);
            if (movie30022962 == null)
            {
                return HttpNotFound();
            }
            return View(movie30022962);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,Name,Duration,Genre,Rating,Price,Description")] Movie30022962 movie30022962)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie30022962).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie30022962);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie30022962 movie30022962 = db.Movie30022962.Find(id);
            if (movie30022962 == null)
            {
                return HttpNotFound();
            }
            return View(movie30022962);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie30022962 movie30022962 = db.Movie30022962.Find(id);
            db.Movie30022962.Remove(movie30022962);
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
