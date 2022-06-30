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

        public DbSet<BorrowingEntity> Borrowings { get; set; }
        public DbSet<BookCopyEntity> Books { get; set; }
        public DbSet<ReaderEntity> Readers { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
