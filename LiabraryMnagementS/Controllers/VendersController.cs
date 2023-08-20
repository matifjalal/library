using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LiabraryMnagementS.Models;

namespace LiabraryMnagementS.Controllers
{
    public class VendersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Venders
        public async Task<IActionResult> Index()
        {
              return _context.Venders != null ? 
                          View(await _context.Venders.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Venders'  is null.");
        }

        // GET: Venders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Venders == null)
            {
                return NotFound();
            }

            var vender = await _context.Venders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vender == null)
            {
                return NotFound();
            }

            return View(vender);
        }

        // GET: Venders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Venders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,PhonNo")] Vender vender)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vender);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vender);
        }

        // GET: Venders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Venders == null)
            {
                return NotFound();
            }

            var vender = await _context.Venders.FindAsync(id);
            if (vender == null)
            {
                return NotFound();
            }
            return View(vender);
        }

        // POST: Venders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,PhonNo")] Vender vender)
        {
            if (id != vender.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VenderExists(vender.Id))
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
            return View(vender);
        }

        // GET: Venders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Venders == null)
            {
                return NotFound();
            }

            var vender = await _context.Venders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vender == null)
            {
                return NotFound();
            }

            return View(vender);
        }

        // POST: Venders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Venders == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Venders'  is null.");
            }
            var vender = await _context.Venders.FindAsync(id);
            if (vender != null)
            {
                _context.Venders.Remove(vender);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VenderExists(int id)
        {
          return (_context.Venders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
