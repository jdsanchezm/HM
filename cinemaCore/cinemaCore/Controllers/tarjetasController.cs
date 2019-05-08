using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cinemaCore.Models;

namespace cinemaCore.Controllers
{
    public class tarjetasController : Controller
    {
        private readonly cinemaCoreContext _context;

        public tarjetasController(cinemaCoreContext context)
        {
            _context = context;
        }

        // GET: tarjetas
        public async Task<IActionResult> Index()
        {
            return View(await _context.tarjeta.ToListAsync());
        }

        // GET: tarjetas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.tarjeta
                .SingleOrDefaultAsync(m => m.idTarjeta == id);
            if (tarjeta == null)
            {
                return NotFound();
            }

            return View(tarjeta);
        }

        // GET: tarjetas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tarjetas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTarjeta,docPropietario,nombrePropietario,saldo,recarga")] tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tarjeta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarjeta);
        }

        // GET: tarjetas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.tarjeta.SingleOrDefaultAsync(m => m.idTarjeta == id);
            if (tarjeta == null)
            {
                return NotFound();
            }
            return View(tarjeta);
        }

        // POST: tarjetas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTarjeta,docPropietario,nombrePropietario,saldo,recarga")] tarjeta tarjeta)
        {
            if (id != tarjeta.idTarjeta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tarjeta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tarjetaExists(tarjeta.idTarjeta))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tarjeta);
        }

        // GET: tarjetas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.tarjeta
                .SingleOrDefaultAsync(m => m.idTarjeta == id);
            if (tarjeta == null)
            {
                return NotFound();
            }

            return View(tarjeta);
        }

        // POST: tarjetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tarjeta = await _context.tarjeta.SingleOrDefaultAsync(m => m.idTarjeta == id);
            _context.tarjeta.Remove(tarjeta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tarjetaExists(int id)
        {
            return _context.tarjeta.Any(e => e.idTarjeta == id);
        }
    }
}
