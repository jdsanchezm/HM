using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CinemaMVC.Models;

namespace CinemaMVC.Controllers
{
    public class SillasController : Controller
    {
        private CineEntities db = new CineEntities();

        // GET: Sillas
        public ActionResult Index()
        {
            var silla = db.Silla.Include(s => s.reserva).Include(s => s.Sala);
            return View(silla.ToList());
        }

        // GET: Sillas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Silla silla = db.Silla.Find(id);
            if (silla == null)
            {
                return HttpNotFound();
            }
            return View(silla);
        }

        // GET: Sillas/Create
        public ActionResult Create()
        {
            ViewBag.fkIdReserva = new SelectList(db.reserva, "idReserva", "estadoPago");
            ViewBag.fkNoSala = new SelectList(db.Sala, "noSala", "noSala");
            return View();
        }

        // POST: Sillas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fila,noSilla,tipo,estado,cantidad,idSilla,fkNoSala,fkIdReserva")] Silla silla)
        {
            if (ModelState.IsValid)
            {
                db.Silla.Add(silla);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fkIdReserva = new SelectList(db.reserva, "idReserva", "estadoPago", silla.fkIdReserva);
            ViewBag.fkNoSala = new SelectList(db.Sala, "noSala", "noSala", silla.fkNoSala);
            return View(silla);
        }

        // GET: Sillas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Silla silla = db.Silla.Find(id);
            if (silla == null)
            {
                return HttpNotFound();
            }
            ViewBag.fkIdReserva = new SelectList(db.reserva, "idReserva", "estadoPago", silla.fkIdReserva);
            ViewBag.fkNoSala = new SelectList(db.Sala, "noSala", "noSala", silla.fkNoSala);
            return View(silla);
        }

        // POST: Sillas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fila,noSilla,tipo,estado,cantidad,idSilla,fkNoSala,fkIdReserva")] Silla silla)
        {
            if (ModelState.IsValid)
            {
                db.Entry(silla).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fkIdReserva = new SelectList(db.reserva, "idReserva", "estadoPago", silla.fkIdReserva);
            ViewBag.fkNoSala = new SelectList(db.Sala, "noSala", "noSala", silla.fkNoSala);
            return View(silla);
        }

        // GET: Sillas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Silla silla = db.Silla.Find(id);
            if (silla == null)
            {
                return HttpNotFound();
            }
            return View(silla);
        }

        // POST: Sillas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Silla silla = db.Silla.Find(id);
            db.Silla.Remove(silla);
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
