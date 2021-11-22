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
    public class demokhoangoaiController : Controller
    {
        private readonly applicatinodbContext _context;

        public demokhoangoaiController(applicatinodbContext context)
        {
            _context = context;
        }

        // GET: demokhoangoai
        public async Task<IActionResult> Index()
        {
            var applicatinodbContext = _context.demokhoangoai.Include(d => d.teskhoatrong);
            return View(await applicatinodbContext.ToListAsync());
        }

        // GET: demokhoangoai/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokhoangoai = await _context.demokhoangoai
                .Include(d => d.teskhoatrong)
                .FirstOrDefaultAsync(m => m.demokhoangoaiID == id);
            if (demokhoangoai == null)
            {
                return NotFound();
            }

            return View(demokhoangoai);
        }

        // GET: demokhoangoai/Create
        public IActionResult Create()
        {
            ViewData["teskhoatrongID"] = new SelectList(_context.Set<teskhoatrong>(), "teskhoatrongID", "teskhoatrongName");
            return View();
        }

        // POST: demokhoangoai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("demokhoangoaiID,demokhoangoaiName,UnitPrice,Quantity,teskhoatrongID")] demokhoangoai demokhoangoai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demokhoangoai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["teskhoatrongID"] = new SelectList(_context.Set<teskhoatrong>(), "teskhoatrongID", "teskhoatrongName", demokhoangoai.teskhoatrongID);
            return View(demokhoangoai);
        }

        // GET: demokhoangoai/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokhoangoai = await _context.demokhoangoai.FindAsync(id);
            if (demokhoangoai == null)
            {
                return NotFound();
            }
            ViewData["teskhoatrongID"] = new SelectList(_context.Set<teskhoatrong>(), "teskhoatrongID", "teskhoatrongName", demokhoangoai.teskhoatrongID);
            return View(demokhoangoai);
        }

        // POST: demokhoangoai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("demokhoangoaiID,demokhoangoaiName,UnitPrice,Quantity,teskhoatrongID")] demokhoangoai demokhoangoai)
        {
            if (id != demokhoangoai.demokhoangoaiID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demokhoangoai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!demokhoangoaiExists(demokhoangoai.demokhoangoaiID))
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
            ViewData["teskhoatrongID"] = new SelectList(_context.Set<teskhoatrong>(), "teskhoatrongID", "teskhoatrongName", demokhoangoai.teskhoatrongID);
            return View(demokhoangoai);
        }

        // GET: demokhoangoai/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokhoangoai = await _context.demokhoangoai
                .Include(d => d.teskhoatrong)
                .FirstOrDefaultAsync(m => m.demokhoangoaiID == id);
            if (demokhoangoai == null)
            {
                return NotFound();
            }

            return View(demokhoangoai);
        }

        // POST: demokhoangoai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var demokhoangoai = await _context.demokhoangoai.FindAsync(id);
            _context.demokhoangoai.Remove(demokhoangoai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool demokhoangoaiExists(string id)
        {
            return _context.demokhoangoai.Any(e => e.demokhoangoaiID == id);
        }
    }
}
