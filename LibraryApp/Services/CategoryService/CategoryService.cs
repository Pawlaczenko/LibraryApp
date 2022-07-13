using LibraryApp.Models;
using LibraryApp.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly LibraryDbContext _dbContext;
        public CategoryService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            IEnumerable<Category> categories = await _dbContext.Categories.ToListAsync();

            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            Category c = _dbContext.Categories.Where(c => c.Id == categoryId).FirstOrDefault();

            return c;
        }
    }
}