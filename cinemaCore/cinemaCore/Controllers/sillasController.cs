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
    public class sillasController : Controller
    {
        private readonly cinemaCoreContext _context;

        public sillasController(cinemaCoreContext context)
        {
            _context = context;
        }

        // GET: sillas
        public async Task<IActionResult> Index()
        {
            return View(await _context.silla.ToListAsync());
        }

        // GET: sillas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var silla = await _context.silla
                .SingleOrDefaultAsync(m => m.idSilla == id);
            if (silla == null)
            {
                return NotFound();
            }

            return View(silla);
        }

        // GET: sillas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sillas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idSilla,fila,noSilla,tipo,estado")] silla silla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(silla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(silla);
        }

        // GET: sillas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var silla = await _context.silla.SingleOrDefaultAsync(m => m.idSilla == id);
            if (silla == null)
            {
                return NotFound();
            }
            return View(silla);
        }

        // POST: sillas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idSilla,fila,noSilla,tipo,estado")] silla silla)
        {
            if (id != silla.idSilla)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(silla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sillaExists(silla.idSilla))
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
            return View(silla);
        }

        // GET: sillas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var silla = await _context.silla
                .SingleOrDefaultAsync(m => m.idSilla == id);
            if (silla == null)
            {
                return NotFound();
            }

            return View(silla);
        }

        // POST: sillas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var silla = await _context.silla.SingleOrDefaultAsync(m => m.idSilla == id);
            _context.silla.Remove(silla);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sillaExists(int id)
        {
            return _context.silla.Any(e => e.idSilla == id);
        }
    }
}
