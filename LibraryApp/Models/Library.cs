using LibraryApp.Exceptions;
using LibraryApp.Services;
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
        private readonly IBorrowingService _borrowingService;

        public Library(string name, IBorrowingService borrowingService)
        {
            Name = name;
            _borrowingService = borrowingService;
        }

        /// <summary>
        /// Get all the borrowings
        /// </summary>
        /// <returns>All borrowing</returns>
        public async Task<IEnumerable<Borrowing>> GetBorrowings()
        {
            return await _borrowingService.GetAllBorrowings();
        }

        /// <summary>
        /// Create a new borrowing
        /// </summary>
        /// <param name="borrowing">The incoming reservation</param>
        /// <exception cref="BorrowingConflictException"></exception>
        public void CreateBorrowing(Borrowing borrowing)
        {
            //foreach(Borrowing existingBorrowing in _borrowings)
            //{
            //    if (existingBorrowing.Conflicts(borrowing))
            //    {
            //        throw new BorrowingConflictException(existingBorrowing,borrowing);
            //    }
            //}

        }
    }
}
