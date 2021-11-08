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
    public class presonController : Controller
    {
        private readonly applicatinodbContext _context;

        public presonController(applicatinodbContext context)
        {
            _context = context;
        }

        // GET: preson
        public async Task<IActionResult> Index()
        {
            return View(await _context.preson.ToListAsync());
        }

        // GET: preson/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preson = await _context.preson
                .FirstOrDefaultAsync(m => m.nameID == id);
            if (preson == null)
            {
                return NotFound();
            }

            return View(preson);
        }

        // GET: preson/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: preson/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nameID,ReleaseDate,Genre,Price")] preson preson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preson);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(preson);
        }

        // GET: preson/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preson = await _context.preson.FindAsync(id);
            if (preson == null)
            {
                return NotFound();
            }
            return View(preson);
        }

        // POST: preson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("nameID,ReleaseDate,Genre,Price")] preson preson)
        {
            if (id != preson.nameID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!presonExists(preson.nameID))
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
            return View(preson);
        }

        // GET: preson/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preson = await _context.preson
                .FirstOrDefaultAsync(m => m.nameID == id);
            if (preson == null)
            {
                return NotFound();
            }

            return View(preson);
        }

        // POST: preson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var preson = await _context.preson.FindAsync(id);
            _context.preson.Remove(preson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool presonExists(string id)
        {
            return _context.preson.Any(e => e.nameID == id);
        }
    }
}
