using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.FluentConfig
{
    public class FluentBorrowingConfig : IEntityTypeConfiguration<Borrowing>
    {
        public void Configure(EntityTypeBuilder<Borrowing> modelBuilder)
        {
            modelBuilder.Property(i => i.BorrowingDate).IsRequired();
            modelBuilder.Property(i => i.BookCopyId).IsRequired();
            modelBuilder.Property(i => i.ReaderId).IsRequired();

            modelBuilder.HasOne(u => u.BookCopy).WithMany(f => f.Borrowings).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.HasOne(u => u.Reader).WithMany(f => f.Borrowings).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
