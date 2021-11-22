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
    public class teskhoatrongController : Controller
    {
        private readonly applicatinodbContext _context;

        public teskhoatrongController(applicatinodbContext context)
        {
            _context = context;
        }

        // GET: teskhoatrong
        public async Task<IActionResult> Index()
        {
            return View(await _context.teskhoatrong.ToListAsync());
        }

        // GET: teskhoatrong/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teskhoatrong = await _context.teskhoatrong
                .FirstOrDefaultAsync(m => m.teskhoatrongID == id);
            if (teskhoatrong == null)
            {
                return NotFound();
            }

            return View(teskhoatrong);
        }

        // GET: teskhoatrong/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: teskhoatrong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("teskhoatrongID,teskhoatrongName")] teskhoatrong teskhoatrong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teskhoatrong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teskhoatrong);
        }

        // GET: teskhoatrong/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teskhoatrong = await _context.teskhoatrong.FindAsync(id);
            if (teskhoatrong == null)
            {
                return NotFound();
            }
            return View(teskhoatrong);
        }

        // POST: teskhoatrong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("teskhoatrongID,teskhoatrongName")] teskhoatrong teskhoatrong)
        {
            if (id != teskhoatrong.teskhoatrongID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teskhoatrong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!teskhoatrongExists(teskhoatrong.teskhoatrongID))
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
            return View(teskhoatrong);
        }

        // GET: teskhoatrong/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teskhoatrong = await _context.teskhoatrong
                .FirstOrDefaultAsync(m => m.teskhoatrongID == id);
            if (teskhoatrong == null)
            {
                return NotFound();
            }

            return View(teskhoatrong);
        }

        // POST: teskhoatrong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var teskhoatrong = await _context.teskhoatrong.FindAsync(id);
            _context.teskhoatrong.Remove(teskhoatrong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool teskhoatrongExists(string id)
        {
            return _context.teskhoatrong.Any(e => e.teskhoatrongID == id);
        }
    }
}
