using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public interface IBorrowingService
    {
        Task<IEnumerable<Borrowing>> GetAllBorrowings();
    }
}
