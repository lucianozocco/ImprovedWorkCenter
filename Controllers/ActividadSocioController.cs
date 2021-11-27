using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImprovedWorkCenter.Models;

namespace ImprovedWorkCenter.Context
{
    public class ActividadSocioController : Controller
    {
        private readonly ImprovedWorkCenterContext _context;

        public ActividadSocioController(ImprovedWorkCenterContext context)
        {
            _context = context;
        }

        // GET: ActividadSocio
        public async Task<IActionResult> Index()
        {
            var improvedWorkCenterContext = _context.ActividadSocios.Include(a => a.Actividad).Include(a => a.Socio);
            return View(await improvedWorkCenterContext.ToListAsync());
        }

        // GET: ActividadSocio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividadSocio = await _context.ActividadSocios
                .Include(a => a.Actividad)
                .Include(a => a.Socio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actividadSocio == null)
            {
                return NotFound();
            }

            return View(actividadSocio);
        }

        // GET: ActividadSocio/Create
        public IActionResult Create()
        {
            ViewData["ActividadId"] = new SelectList(_context.Socios, "ActividadId", "ActividadId");
            ViewData["SocioId"] = new SelectList(_context.Actividades, "SocioId", "SocioId");
            return View();
        }

        // POST: ActividadSocio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ActividadId,SocioId")] ActividadSocio actividadSocio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividadSocio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActividadId"] = new SelectList(_context.Socios, "ActividadId", "ActividadId", actividadSocio.ActividadId);
            ViewData["SocioId"] = new SelectList(_context.Actividades, "SocioId", "SocioId", actividadSocio.SocioId);
            return View(actividadSocio);
        }

        // GET: ActividadSocio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividadSocio = await _context.ActividadSocios.FindAsync(id);
            if (actividadSocio == null)
            {
                return NotFound();
            }
            ViewData["ActividadId"] = new SelectList(_context.Socios, "ActividadId", "ActividadId", actividadSocio.ActividadId);
            ViewData["SocioId"] = new SelectList(_context.Actividades, "SocioId", "SocioId", actividadSocio.SocioId);
            return View(actividadSocio);
        }

        // POST: ActividadSocio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ActividadId,SocioId")] ActividadSocio actividadSocio)
        {
            if (id != actividadSocio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actividadSocio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActividadSocioExists(actividadSocio.Id))
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
            ViewData["ActividadId"] = new SelectList(_context.Socios, "ActividadId", "ActividadId", actividadSocio.ActividadId);
            ViewData["SocioId"] = new SelectList(_context.Actividades, "SocioId", "SocioId", actividadSocio.SocioId);
            return View(actividadSocio);
        }

        // GET: ActividadSocio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividadSocio = await _context.ActividadSocios
                .Include(a => a.Actividad)
                .Include(a => a.Socio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actividadSocio == null)
            {
                return NotFound();
            }

            return View(actividadSocio);
        }

        // POST: ActividadSocio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actividadSocio = await _context.ActividadSocios.FindAsync(id);
            _context.ActividadSocios.Remove(actividadSocio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActividadSocioExists(int id)
        {
            return _context.ActividadSocios.Any(e => e.Id == id);
        }
    }
}
