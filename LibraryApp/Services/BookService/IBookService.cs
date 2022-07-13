using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookCopy>> GetAllBooks();
        Task CreateBook(BookCopy book);
        BookCopy GetBookById(int bookId);
    }
}
