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
    public class BooksCatagoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksCatagoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BooksCatagories
        public async Task<IActionResult> Index()
        {
              return _context.BooksCatagories != null ? 
                          View(await _context.BooksCatagories.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.BooksCatagories'  is null.");
        }

        // GET: BooksCatagories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BooksCatagories == null)
            {
                return NotFound();
            }

            var booksCatagory = await _context.BooksCatagories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booksCatagory == null)
            {
                return NotFound();
            }

            return View(booksCatagory);
        }

        // GET: BooksCatagories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BooksCatagories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] BooksCatagory booksCatagory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booksCatagory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booksCatagory);
        }

        // GET: BooksCatagories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BooksCatagories == null)
            {
                return NotFound();
            }

            var booksCatagory = await _context.BooksCatagories.FindAsync(id);
            if (booksCatagory == null)
            {
                return NotFound();
            }
            return View(booksCatagory);
        }

        // POST: BooksCatagories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] BooksCatagory booksCatagory)
        {
            if (id != booksCatagory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booksCatagory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BooksCatagoryExists(booksCatagory.Id))
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
            return View(booksCatagory);
        }

        // GET: BooksCatagories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BooksCatagories == null)
            {
                return NotFound();
            }

            var booksCatagory = await _context.BooksCatagories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booksCatagory == null)
            {
                return NotFound();
            }

            return View(booksCatagory);
        }

        // POST: BooksCatagories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BooksCatagories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BooksCatagories'  is null.");
            }
            var booksCatagory = await _context.BooksCatagories.FindAsync(id);
            if (booksCatagory != null)
            {
                _context.BooksCatagories.Remove(booksCatagory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BooksCatagoryExists(int id)
        {
          return (_context.BooksCatagories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
