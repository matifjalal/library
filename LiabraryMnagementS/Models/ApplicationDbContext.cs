

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

        public DbSet<LiabraryMnagementS.Models.UserInfo>? UserInfo { get; set; }

        
    }
}