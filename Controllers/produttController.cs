using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using demotest.Models;
using demotest.data;

namespace demotest.Controllers
{
    public class produttController : Controller
    {
        private readonly applicatinodbContext _context;

        public produttController(applicatinodbContext context)
        {
            _context = context;
        }

        // GET: produtt
        public async Task<IActionResult> Index()
        {
            var applicatinodbContext = _context.Productt.Include(p => p.categoryy);
            return View(await applicatinodbContext.ToListAsync());
        }

        // GET: produtt/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productt = await _context.Productt
                .Include(p => p.categoryy)
                .FirstOrDefaultAsync(m => m.ProducttID == id);
            if (productt == null)
            {
                return NotFound();
            }

            return View(productt);
        }

        // GET: produtt/Create
        public IActionResult Create()
        {
            ViewData["categoryyID"] = new SelectList(_context.Set<categoryy>(), "categoryyID", "categoryyName");
            return View();
        }

        // POST: produtt/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProducttID,ProducttName,UnitPrice,Quantity,categoryyID")] Productt productt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["categoryyID"] = new SelectList(_context.Set<categoryy>(), "categoryyID", "categoryyName", productt.categoryyID);
            return View(productt);
        }

        // GET: produtt/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productt = await _context.Productt.FindAsync(id);
            if (productt == null)
            {
                return NotFound();
            }
            ViewData["categoryyID"] = new SelectList(_context.Set<categoryy>(), "categoryyID", "categoryyName", productt.categoryyID);
            return View(productt);
        }

        // POST: produtt/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProducttID,ProducttName,UnitPrice,Quantity,categoryyID")] Productt productt)
        {
            if (id != productt.ProducttID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProducttExists(productt.ProducttID))
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
            ViewData["categoryyID"] = new SelectList(_context.Set<categoryy>(), "categoryyID", "categoryyName", productt.categoryyID);
            return View(productt);
        }

        // GET: produtt/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productt = await _context.Productt
                .Include(p => p.categoryy)
                .FirstOrDefaultAsync(m => m.ProducttID == id);
            if (productt == null)
            {
                return NotFound();
            }

            return View(productt);
        }

        // POST: produtt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var productt = await _context.Productt.FindAsync(id);
            _context.Productt.Remove(productt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProducttExists(string id)
        {
            return _context.Productt.Any(e => e.ProducttID == id);
        }
    }
}
