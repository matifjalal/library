

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

        public DbSet<BookPurchase> bookPurchases { get; set; }

        public DbSet<CustomerReservation> customerReservations { get; set; }

    }
}