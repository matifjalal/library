﻿

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

        public DbSet<BookSale> ‌‌Booksales { get; set; }

        public DbSet<BookReservation> Bookreservations { get; set; }

        public DbSet <Author> Authors { get; set; }

        public DbSet <Currancy> Currancies { get; set; }

        public DbSet <Vender> Venders { get; set; }

    }
}