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
    public class BookSalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookSalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookSales
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BookSale.Include(b => b.Book).Include(b => b.Customer).Include(b => b.Vender);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BookSales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BookSale == null)
            {
                return NotFound();
            }

            var bookSale = await _context.BookSale
                .Include(b => b.Book)
                .Include(b => b.Customer)
                .Include(b => b.Vender)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookSale == null)
            {
                return NotFound();
            }

            return View(bookSale);
        }

        // GET: BookSales/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id");
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id");
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id");
            return View();
        }

        // POST: BookSales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookId,CustomerId,VenderId")] BookSale bookSale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookSale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookSale.BookId);
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id", bookSale.CustomerId);
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id", bookSale.VenderId);
            return View(bookSale);
        }

        // GET: BookSales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BookSale == null)
            {
                return NotFound();
            }

            var bookSale = await _context.BookSale.FindAsync(id);
            if (bookSale == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookSale.BookId);
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id", bookSale.CustomerId);
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id", bookSale.VenderId);
            return View(bookSale);
        }

        // POST: BookSales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookId,CustomerId,VenderId")] BookSale bookSale)
        {
            if (id != bookSale.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookSale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookSaleExists(bookSale.Id))
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
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookSale.BookId);
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id", bookSale.CustomerId);
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id", bookSale.VenderId);
            return View(bookSale);
        }

        // GET: BookSales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BookSale == null)
            {
                return NotFound();
            }

            var bookSale = await _context.BookSale
                .Include(b => b.Book)
                .Include(b => b.Customer)
                .Include(b => b.Vender)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookSale == null)
            {
                return NotFound();
            }

            return View(bookSale);
        }

        // POST: BookSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BookSale == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BookSale'  is null.");
            }
            var bookSale = await _context.BookSale.FindAsync(id);
            if (bookSale != null)
            {
                _context.BookSale.Remove(bookSale);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookSaleExists(int id)
        {
          return (_context.BookSale?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
