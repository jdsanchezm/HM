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
    public class encargoesController : Controller
    {
        private RingsOnFireEntities db = new RingsOnFireEntities();

        // GET: encargoes
        public ActionResult Index()
        {
            var encargo = db.encargo.Include(e => e.anillo).Include(e => e.cliente);
            return View(encargo.ToList());
        }

        // GET: encargoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encargo encargo = db.encargo.Find(id);
            if (encargo == null)
            {
                return HttpNotFound();
            }
            return View(encargo);
        }

        // GET: encargoes/Create
        public ActionResult Create()
        {
            ViewBag.fkAnillo = new SelectList(db.anillo, "idAnillo", "material");
            ViewBag.fkCliente = new SelectList(db.cliente, "idCliente", "nombre");
            return View();
        }

        // POST: encargoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEncargo,fechaEncargo,fechaEntrega,monto,fkCliente,fkAnillo")] encargo encargo)
        {
            if (ModelState.IsValid)
            {
                db.encargo.Add(encargo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fkAnillo = new SelectList(db.anillo, "idAnillo", "material", encargo.fkAnillo);
            ViewBag.fkCliente = new SelectList(db.cliente, "idCliente", "nombre", encargo.fkCliente);
            return View(encargo);
        }

        // GET: encargoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encargo encargo = db.encargo.Find(id);
            if (encargo == null)
            {
                return HttpNotFound();
            }
            ViewBag.fkAnillo = new SelectList(db.anillo, "idAnillo", "material", encargo.fkAnillo);
            ViewBag.fkCliente = new SelectList(db.cliente, "idCliente", "nombre", encargo.fkCliente);
            return View(encargo);
        }

        // POST: encargoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEncargo,fechaEncargo,fechaEntrega,monto,fkCliente,fkAnillo")] encargo encargo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encargo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fkAnillo = new SelectList(db.anillo, "idAnillo", "material", encargo.fkAnillo);
            ViewBag.fkCliente = new SelectList(db.cliente, "idCliente", "nombre", encargo.fkCliente);
            return View(encargo);
        }

        // GET: encargoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encargo encargo = db.encargo.Find(id);
            if (encargo == null)
            {
                return HttpNotFound();
            }
            return View(encargo);
        }

        // POST: encargoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            encargo encargo = db.encargo.Find(id);
            db.encargo.Remove(encargo);
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
