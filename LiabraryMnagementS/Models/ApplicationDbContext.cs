

using Microsoft.EntityFrameworkCore;

namespace LiabraryMnagementS.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<BooksCatagory> booksCatagories { get; set; }

        public DbSet<Books> books { get; set; }

        
    }
}