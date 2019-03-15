using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Controllers
{
    public class OvaController : Controller
    {
        private readonly LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext _context;

        public OvaController(LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext context)
        {
            _context = context;
        }

        // GET: Ova
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ova.ToListAsync());
        }

        // GET: Ova/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ova = await _context.Ova
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ova == null)
            {
                return NotFound();
            }

            return View(ova);
        }

        // GET: Ova/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ova/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoOva,Año,Nombre,Capitulos,Duracion")] Ova ova)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ova);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ova);
        }

        // GET: Ova/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ova = await _context.Ova.FindAsync(id);
            if (ova == null)
            {
                return NotFound();
            }
            return View(ova);
        }

        // POST: Ova/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoOva,Año,Nombre,Capitulos,Duracion")] Ova ova)
        {
            if (id != ova.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ova);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OvaExists(ova.Id))
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
            return View(ova);
        }

        // GET: Ova/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ova = await _context.Ova
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ova == null)
            {
                return NotFound();
            }

            return View(ova);
        }

        // POST: Ova/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ova = await _context.Ova.FindAsync(id);
            _context.Ova.Remove(ova);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OvaExists(int id)
        {
            return _context.Ova.Any(e => e.Id == id);
        }
    }
}
