using LibraryApp.FluentConfig;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.AppDbContext
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<BookCopy> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new FluentBookCopyConfig());
            modelBuilder.ApplyConfiguration(new FluentBorrowingConfig());
            modelBuilder.ApplyConfiguration(new FluentCategoryConfig());
            modelBuilder.ApplyConfiguration(new FluentReaderConfig());
        }
    }
}
