using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JorgeRamos_ExamenProgreso_1.Data;
using JorgeRamos_ExamenProgreso_1.Models;

namespace JorgeRamos_ExamenProgreso_1.Controllers
{
    public class RecompensasController : Controller
    {
        private readonly JorgeRamos_ExamenProgreso_1Context _context;

        public RecompensasController(JorgeRamos_ExamenProgreso_1Context context)
        {
            _context = context;
        }

        // GET: Recompensas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recompensas.ToListAsync());
        }

        // GET: Recompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensas = await _context.Recompensas
                .FirstOrDefaultAsync(m => m.RecompensaId == id);
            if (recompensas == null)
            {
                return NotFound();
            }

            return View(recompensas);
        }

        // GET: Recompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecompensaId,Nombre,FechaInicio,PuntosAcumulados")] Recompensas recompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recompensas);
        }

        // GET: Recompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensas = await _context.Recompensas.FindAsync(id);
            if (recompensas == null)
            {
                return NotFound();
            }
            return View(recompensas);
        }

        // POST: Recompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecompensaId,Nombre,FechaInicio,PuntosAcumulados")] Recompensas recompensas)
        {
            if (id != recompensas.RecompensaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecompensasExists(recompensas.RecompensaId))
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
            return View(recompensas);
        }

        // GET: Recompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensas = await _context.Recompensas
                .FirstOrDefaultAsync(m => m.RecompensaId == id);
            if (recompensas == null)
            {
                return NotFound();
            }

            return View(recompensas);
        }

        // POST: Recompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recompensas = await _context.Recompensas.FindAsync(id);
            if (recompensas != null)
            {
                _context.Recompensas.Remove(recompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecompensasExists(int id)
        {
            return _context.Recompensas.Any(e => e.RecompensaId == id);
        }
    }
}
