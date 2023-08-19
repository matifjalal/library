

using Microsoft.EntityFrameworkCore;
using LiabraryMnagementS.Models;

namespace LiabraryMnagementS.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<BooksCatagory> BooksCatagories { get; set; }
        public DbSet<Book> Book { get; set; }

        public DbSet<LiabraryMnagementS.Models.Customer>? customers { get; set; }

        public DbSet<BookSale> BookSale { get; set; }

        public DbSet<BookReservation>BookReservations{ get; set; }

        public DbSet <Author> Authors { get; set; }

        public DbSet <Currency> Currencies { get; set; }

        public DbSet <Vender> Venders { get; set; }

    }
}