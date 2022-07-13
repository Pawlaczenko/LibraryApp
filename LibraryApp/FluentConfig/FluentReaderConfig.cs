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
    public class FluentReaderConfig : IEntityTypeConfiguration<Reader>
    {
        public void Configure(EntityTypeBuilder<Reader> modelBuilder)
        {
            modelBuilder.HasIndex(i => i.CardNumber).IsUnique();
            modelBuilder.Property(i => i.FirstName).IsRequired().HasMaxLength(30);
            modelBuilder.Property(i => i.LastName).IsRequired().HasMaxLength(30);
        }
    }
}
