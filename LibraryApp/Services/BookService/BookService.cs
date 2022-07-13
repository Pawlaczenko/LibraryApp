using LibraryApp.Models;
using LibraryApp.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext _dbContext;
        public BookService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateBook(BookCopy book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookCopy>> GetAllBooks()
        {
            IEnumerable<BookCopy> books = await _dbContext.Books.ToListAsync();

            return books;
        }

        public BookCopy GetBookById(int bookId)
        {
            BookCopy b = _dbContext.Books.Where(b => b.BookCopyId == bookId).FirstOrDefault();

            return b;
        }
    }
}