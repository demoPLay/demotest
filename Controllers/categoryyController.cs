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
    public class categoryyController : Controller
    {
        private readonly applicatinodbContext _context;

        public categoryyController(applicatinodbContext context)
        {
            _context = context;
        }

        // GET: categoryy
        public async Task<IActionResult> Index()
        {
            return View(await _context.categoryy.ToListAsync());
        }

        // GET: categoryy/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryy = await _context.categoryy
                .FirstOrDefaultAsync(m => m.categoryyID == id);
            if (categoryy == null)
            {
                return NotFound();
            }

            return View(categoryy);
        }

        // GET: categoryy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: categoryy/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("categoryyID,categoryyName")] categoryy categoryy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryy);
        }

        // GET: categoryy/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryy = await _context.categoryy.FindAsync(id);
            if (categoryy == null)
            {
                return NotFound();
            }
            return View(categoryy);
        }

        // POST: categoryy/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("categoryyID,categoryyName")] categoryy categoryy)
        {
            if (id != categoryy.categoryyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!categoryyExists(categoryy.categoryyID))
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
            return View(categoryy);
        }

        // GET: categoryy/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryy = await _context.categoryy
                .FirstOrDefaultAsync(m => m.categoryyID == id);
            if (categoryy == null)
            {
                return NotFound();
            }

            return View(categoryy);
        }

        // POST: categoryy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var categoryy = await _context.categoryy.FindAsync(id);
            _context.categoryy.Remove(categoryy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool categoryyExists(string id)
        {
            return _context.categoryy.Any(e => e.categoryyID == id);
        }
    }
}
