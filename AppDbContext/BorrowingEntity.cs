using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.AppDbContext
{
    public class BorrowingEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public ReaderEntity Reader { get; set; }
        [Required]
        public DateTime BorrowingDate { get; set; }
        [Required]
        public BookCopyEntity Book { get; set;}

    }
}
