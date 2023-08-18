

using Microsoft.EntityFrameworkCore;
using LiabraryMnagementS.Models;

namespace LiabraryMnagementS.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<BooksCatagory> booksCatagories { get; set; }

        public DbSet<Books> books { get; set; }

        public DbSet<LiabraryMnagementS.Models.Customer>? customers { get; set; }

        public DbSet<BookSales> booksales { get; set; }

        public DbSet<BookReservation> bookreservations { get; set; }

        public DbSet <Author> authors { get; set; }

        public DbSet <Currancy> currancies { get; set; }

        public DbSet <Vender> venders { get; set; }

    }
}