using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.AppDbContext
{
    public class BookCopyEntity
    {
        [Key]
        public int BookCopyId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public bool IsBorrowed { get; set; }
        public DateTime ReleaseDate { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
