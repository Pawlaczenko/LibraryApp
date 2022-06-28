using LibraryApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Library
    {
        public string Name { get; }
        private readonly List<Borrowing> _borrowings;

        public Library(string name)
        {
            Name = name;
            _borrowings = new List<Borrowing>();
        }

        /// <summary>
        /// Get all the borrowings
        /// </summary>
        /// <returns>All borrowing</returns>
        public IEnumerable<Borrowing> GetBorrowings()
        {
            return _borrowings;
        }

        /// <summary>
        /// Create a new borrowing
        /// </summary>
        /// <param name="borrowing">The incoming reservation</param>
        /// <exception cref="BorrowingConflictException"></exception>
        public void CreateBorrowing(Borrowing borrowing)
        {
            foreach(Borrowing existingBorrowing in _borrowings)
            {
                if (existingBorrowing.Conflicts(borrowing))
                {
                    throw new BorrowingConflictException(existingBorrowing,borrowing);
                }
            }

            _borrowings.Add(borrowing);
        }
    }
}
