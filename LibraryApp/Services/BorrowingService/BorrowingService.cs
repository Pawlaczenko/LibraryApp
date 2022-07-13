using LibraryApp.Models;
using LibraryApp.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class BorrowingService : IBorrowingService
    {
        private readonly LibraryDbContext _dbContext;
        private readonly BookService _bookService;
        public BorrowingService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Borrowing>> GetAllBorrowings()
        {
            IEnumerable<Borrowing> borrowings = await _dbContext.Borrowings.ToListAsync();

            return borrowings;
        }
    }
}
