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
    public class reservasController : Controller
    {
        private readonly cinemaCoreContext _context;

        public reservasController(cinemaCoreContext context)
        {
            _context = context;
        }

        // GET: reservas
        public async Task<IActionResult> Index()
        {
            return View(await _context.reserva.ToListAsync());
        }

        // GET: reservas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.reserva
                .SingleOrDefaultAsync(m => m.idReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: reservas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: reservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idReserva,docSolicitante,estadoPago,metodoPago,cantidadSillas,fkIdTarjeta")] reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reserva);
        }

        // GET: reservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.reserva.SingleOrDefaultAsync(m => m.idReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }
            return View(reserva);
        }

        // POST: reservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idReserva,docSolicitante,estadoPago,metodoPago,cantidadSillas,fkIdTarjeta")] reserva reserva)
        {
            if (id != reserva.idReserva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!reservaExists(reserva.idReserva))
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
            return View(reserva);
        }

        // GET: reservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.reserva
                .SingleOrDefaultAsync(m => m.idReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.reserva.SingleOrDefaultAsync(m => m.idReserva == id);
            _context.reserva.Remove(reserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool reservaExists(int id)
        {
            return _context.reserva.Any(e => e.idReserva == id);
        }
    }
}
