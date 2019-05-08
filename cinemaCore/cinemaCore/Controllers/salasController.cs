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
    public class salasController : Controller
    {
        private readonly cinemaCoreContext _context;

        public salasController(cinemaCoreContext context)
        {
            _context = context;
        }

        // GET: salas
        public async Task<IActionResult> Index()
        {
            return View(await _context.sala.ToListAsync());
        }

        // GET: salas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sala = await _context.sala
                .SingleOrDefaultAsync(m => m.noSala == id);
            if (sala == null)
            {
                return NotFound();
            }

            return View(sala);
        }

        // GET: salas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: salas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("noSala,ingreso")] sala sala)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sala);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sala);
        }

        // GET: salas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sala = await _context.sala.SingleOrDefaultAsync(m => m.noSala == id);
            if (sala == null)
            {
                return NotFound();
            }
            return View(sala);
        }

        // POST: salas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("noSala,ingreso")] sala sala)
        {
            if (id != sala.noSala)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sala);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!salaExists(sala.noSala))
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
            return View(sala);
        }

        // GET: salas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sala = await _context.sala
                .SingleOrDefaultAsync(m => m.noSala == id);
            if (sala == null)
            {
                return NotFound();
            }

            return View(sala);
        }

        // POST: salas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sala = await _context.sala.SingleOrDefaultAsync(m => m.noSala == id);
            _context.sala.Remove(sala);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool salaExists(int id)
        {
            return _context.sala.Any(e => e.noSala == id);
        }
    }
}
