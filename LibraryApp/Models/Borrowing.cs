using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Borrowing
    {

        public DateTime BorrowingDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string ReaderId { get; set; }
        public int BookCopyId { get; set; }

        public Reader Reader { get; set; }
        public BookCopy BookCopy { get; set; }

        //public Borrowing(BookCopy bookCopy, DateTime borrowingDate, Reader reader)
        //{
        //    BookCopy = bookCopy;
        //    BorrowingDate = borrowingDate;
        //    Reader = reader;
        //}

        /// <summary>
        /// Checks if the incoming borrowing can be created
        /// </summary>
        /// <param name="borrowing">incoming borrowing</param>
        /// <returns>Either true or false depending if the conflicts exists</returns>
        //internal bool Conflicts(Borrowing borrowing)
        //{
        //    if (borrowing.BookCopy.Equals(BookCopy)) return true;
        //    return false;
        //}
    }
}
