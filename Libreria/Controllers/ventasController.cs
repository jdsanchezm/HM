using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Libreria.Models;

namespace Libreria.Controllers
{
    public class ventasController : Controller
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        // GET: ventas
        public ActionResult Index()
        {
            var ventas = db.ventas.Include(v => v.cliente).Include(v => v.libro);
            return View(ventas.ToList());
        }

        // GET: ventas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            venta venta = db.ventas.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // GET: ventas/Create
        public ActionResult Create()
        {
            ViewBag.fkCliente = new SelectList(db.clientes, "idCliente", "nombre");
            ViewBag.fkLibro = new SelectList(db.libroes, "idLibro", "titulo");
            return View();
        }

        // POST: ventas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idVenta,monto,fecha,fkLibro,fkCliente")] venta venta)
        {
            if (ModelState.IsValid)
            {
                db.ventas.Add(venta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fkCliente = new SelectList(db.clientes, "idCliente", "nombre", venta.fkCliente);
            ViewBag.fkLibro = new SelectList(db.libroes, "idLibro", "titulo", venta.fkLibro);
            return View(venta);
        }

        // GET: ventas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            venta venta = db.ventas.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            ViewBag.fkCliente = new SelectList(db.clientes, "idCliente", "nombre", venta.fkCliente);
            ViewBag.fkLibro = new SelectList(db.libroes, "idLibro", "titulo", venta.fkLibro);
            return View(venta);
        }

        // POST: ventas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idVenta,monto,fecha,fkLibro,fkCliente")] venta venta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(venta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fkCliente = new SelectList(db.clientes, "idCliente", "nombre", venta.fkCliente);
            ViewBag.fkLibro = new SelectList(db.libroes, "idLibro", "titulo", venta.fkLibro);
            return View(venta);
        }

        // GET: ventas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            venta venta = db.ventas.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // POST: ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            venta venta = db.ventas.Find(id);
            db.ventas.Remove(venta);
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
