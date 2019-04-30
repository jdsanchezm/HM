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
    public class reservasController : Controller
    {
        private CineEntities db = new CineEntities();

        // GET: reservas
        public ActionResult Index()
        {
            var reserva = db.reserva.Include(r => r.Tarjeta);
            return View(reserva.ToList());
        }

        // GET: reservas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            reserva reserva = db.reserva.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // GET: reservas/Create
        public ActionResult Create()
        {
            ViewBag.fkIdTarjeta = new SelectList(db.Tarjeta, "idTarjeta", "Propietario");
            return View();
        }

        // POST: reservas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idReserva,docSolicitante,precio,estadoPago,metodoDePago,fkIdTarjeta")] reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.reserva.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fkIdTarjeta = new SelectList(db.Tarjeta, "idTarjeta", "Propietario", reserva.fkIdTarjeta);
            return View(reserva);
        }

        // GET: reservas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            reserva reserva = db.reserva.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.fkIdTarjeta = new SelectList(db.Tarjeta, "idTarjeta", "Propietario", reserva.fkIdTarjeta);
            return View(reserva);
        }

        // POST: reservas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idReserva,docSolicitante,precio,estadoPago,metodoDePago,fkIdTarjeta")] reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fkIdTarjeta = new SelectList(db.Tarjeta, "idTarjeta", "Propietario", reserva.fkIdTarjeta);
            return View(reserva);
        }

        // GET: reservas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            reserva reserva = db.reserva.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // POST: reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            reserva reserva = db.reserva.Find(id);
            db.reserva.Remove(reserva);
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
