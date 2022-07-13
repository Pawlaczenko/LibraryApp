using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public interface IReaderService
    {
        Task<IEnumerable<Reader>> GetAllReaders();
        Task CreateReader(Reader reader);
        Reader GetReaderById(string readerId);
    }
}
