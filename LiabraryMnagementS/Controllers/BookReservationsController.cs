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
    public class BookReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookReservations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BookReservations.Include(b => b.Book).Include(b => b.Customer).Include(b => b.Vender);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BookReservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BookReservations == null)
            {
                return NotFound();
            }

            var bookReservation = await _context.BookReservations
                .Include(b => b.Book)
                .Include(b => b.Customer)
                .Include(b => b.Vender)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookReservation == null)
            {
                return NotFound();
            }

            return View(bookReservation);
        }

        // GET: BookReservations/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id");
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id");
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id");
            return View();
        }

        // POST: BookReservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookId,StartDate,EndDate,Cost,CustomerId,VenderId")] BookReservation bookReservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookReservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookReservation.BookId);
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id", bookReservation.CustomerId);
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id", bookReservation.VenderId);
            return View(bookReservation);
        }

        // GET: BookReservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BookReservations == null)
            {
                return NotFound();
            }

            var bookReservation = await _context.BookReservations.FindAsync(id);
            if (bookReservation == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookReservation.BookId);
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id", bookReservation.CustomerId);
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id", bookReservation.VenderId);
            return View(bookReservation);
        }

        // POST: BookReservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookId,StartDate,EndDate,Cost,CustomerId,VenderId")] BookReservation bookReservation)
        {
            if (id != bookReservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookReservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookReservationExists(bookReservation.Id))
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
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookReservation.BookId);
            ViewData["CustomerId"] = new SelectList(_context.customers, "Id", "Id", bookReservation.CustomerId);
            ViewData["VenderId"] = new SelectList(_context.Venders, "Id", "Id", bookReservation.VenderId);
            return View(bookReservation);
        }

        // GET: BookReservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BookReservations == null)
            {
                return NotFound();
            }

            var bookReservation = await _context.BookReservations
                .Include(b => b.Book)
                .Include(b => b.Customer)
                .Include(b => b.Vender)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookReservation == null)
            {
                return NotFound();
            }

            return View(bookReservation);
        }

        // POST: BookReservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BookReservations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BookReservations'  is null.");
            }
            var bookReservation = await _context.BookReservations.FindAsync(id);
            if (bookReservation != null)
            {
                _context.BookReservations.Remove(bookReservation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookReservationExists(int id)
        {
          return (_context.BookReservations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
