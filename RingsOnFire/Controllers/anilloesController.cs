using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RingsOnFire.Models;

namespace RingsOnFire.Controllers
{
    public class anilloesController : Controller
    {
        private RingsOnFireEntities db = new RingsOnFireEntities();

        // GET: anilloes
        public ActionResult Index()
        {
            return View(db.anillo.ToList());
        }

        // GET: anilloes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            anillo anillo = db.anillo.Find(id);
            if (anillo == null)
            {
                return HttpNotFound();
            }
            return View(anillo);
        }

        // GET: anilloes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: anilloes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAnillo,material,circunferencia,peso,precio")] anillo anillo)
        {
            if (ModelState.IsValid)
            {
                db.anillo.Add(anillo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anillo);
        }

        // GET: anilloes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            anillo anillo = db.anillo.Find(id);
            if (anillo == null)
            {
                return HttpNotFound();
            }
            return View(anillo);
        }

        // POST: anilloes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAnillo,material,circunferencia,peso,precio")] anillo anillo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anillo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anillo);
        }

        // GET: anilloes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            anillo anillo = db.anillo.Find(id);
            if (anillo == null)
            {
                return HttpNotFound();
            }
            return View(anillo);
        }

        // POST: anilloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            anillo anillo = db.anillo.Find(id);
            db.anillo.Remove(anillo);
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
