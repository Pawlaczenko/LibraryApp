using LibraryApp.Models;
using LibraryApp.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class ReaderService : IReaderService
    {
        private readonly LibraryDbContext _dbContext;
        public ReaderService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateReader(Reader reader)
        {
            _dbContext.Readers.Add(reader);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Reader>> GetAllReaders()
        {
            IEnumerable<Reader> readers = await _dbContext.Readers.ToListAsync();

            return readers;
        }

        public Reader GetReaderById(string readerId)
        {
            Reader r = _dbContext.Readers.Where(r => r.CardNumber == readerId).FirstOrDefault();

            return r;
        }
    }
}