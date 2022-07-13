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
    public class FluentBookCopyConfig : IEntityTypeConfiguration<BookCopy>
    {
        public void Configure(EntityTypeBuilder<BookCopy> modelBuilder)
        {
            modelBuilder.Property(i => i.Title).IsRequired().HasMaxLength(200);
            modelBuilder.Property(i => i.CategoryId).IsRequired();
            modelBuilder.Property(i => i.IsBorrowed).IsRequired().HasDefaultValue(false);

            modelBuilder.HasOne(i => i.Category).WithMany(i => i.Books).HasForeignKey(i => i.CategoryId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
