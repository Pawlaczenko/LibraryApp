using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Borrowing
    {
        public BookCopy BookCopy { get; }
        public DateTime BorrowingDate { get; }
        public string ReaderCardNumber { get; }

        public Borrowing(BookCopy bookCopy, DateTime borrowingDate, string readerCardNumber)
        {
            BookCopy = bookCopy;
            BorrowingDate = borrowingDate;
            ReaderCardNumber = readerCardNumber;
        }

        /// <summary>
        /// Checks if the incoming borrowing can be created
        /// </summary>
        /// <param name="borrowing">incoming borrowing</param>
        /// <returns>Either true or false depending if the conflicts exists</returns>
        internal bool Conflicts(Borrowing borrowing)
        {
            if (borrowing.BookCopy.Equals(BookCopy)) return true;
            return false;
        }
    }
}
