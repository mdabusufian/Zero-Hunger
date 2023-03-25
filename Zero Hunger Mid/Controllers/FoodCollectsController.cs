using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger_Mid.Models;

namespace Zero_Hunger_Mid.Controllers
{
    public class FoodCollectsController : Controller
    {
        private DataConn db = new DataConn();

        // GET: FoodCollects
        public ActionResult Index()
        {
            var foodCollects = db.FoodCollects.Include(f => f.Rest);
            return View(foodCollects.ToList());
        }

        // GET: FoodCollects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCollect foodCollect = db.FoodCollects.Find(id);
            if (foodCollect == null)
            {
                return HttpNotFound();
            }
            return View(foodCollect);
        }

        // GET: FoodCollects/Create
        public ActionResult Create()
        {
            ViewBag.RestId = new SelectList(db.Rests, "Id", "Name");
            return View();
        }

        // POST: FoodCollects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ExpierdDate,IsCollected,RestId")] FoodCollect foodCollect)
        {
            if (ModelState.IsValid)
            {
                db.FoodCollects.Add(foodCollect);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RestId = new SelectList(db.Rests, "Id", "Name", foodCollect.RestId);
            return View(foodCollect);
        }

        // GET: FoodCollects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCollect foodCollect = db.FoodCollects.Find(id);
            if (foodCollect == null)
            {
                return HttpNotFound();
            }
            ViewBag.RestId = new SelectList(db.Rests, "Id", "Name", foodCollect.RestId);
            return View(foodCollect);
        }

        // POST: FoodCollects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ExpierdDate,IsCollected,RestId")] FoodCollect foodCollect)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodCollect).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RestId = new SelectList(db.Rests, "Id", "Name", foodCollect.RestId);
            return View(foodCollect);
        }

        // GET: FoodCollects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCollect foodCollect = db.FoodCollects.Find(id);
            if (foodCollect == null)
            {
                return HttpNotFound();
            }
            return View(foodCollect);
        }

        // POST: FoodCollects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodCollect foodCollect = db.FoodCollects.Find(id);
            db.FoodCollects.Remove(foodCollect);
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
