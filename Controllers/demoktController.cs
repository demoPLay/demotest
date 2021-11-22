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
    public class demoktController : Controller
    {
        private readonly applicatinodbContext _context;

        public demoktController(applicatinodbContext context)
        {
            _context = context;
        }

        // GET: demokt
        public async Task<IActionResult> Index()
        {
            return View(await _context.demokt.ToListAsync());
        }

        // GET: demokt/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokt = await _context.demokt
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (demokt == null)
            {
                return NotFound();
            }

            return View(demokt);
        }

        // GET: demokt/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: demokt/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("demoktID,demoktName,StudentID,StudentName,Address")] demokt demokt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demokt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demokt);
        }

        // GET: demokt/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokt = await _context.demokt.FindAsync(id);
            if (demokt == null)
            {
                return NotFound();
            }
            return View(demokt);
        }

        // POST: demokt/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("demoktID,demoktName,StudentID,StudentName,Address")] demokt demokt)
        {
            if (id != demokt.StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demokt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!demoktExists(demokt.StudentID))
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
            return View(demokt);
        }

        // GET: demokt/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokt = await _context.demokt
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (demokt == null)
            {
                return NotFound();
            }

            return View(demokt);
        }

        // POST: demokt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var demokt = await _context.demokt.FindAsync(id);
            _context.demokt.Remove(demokt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool demoktExists(string id)
        {
            return _context.demokt.Any(e => e.StudentID == id);
        }
    }
}
