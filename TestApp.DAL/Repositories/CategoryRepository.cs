using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Entities;
using TestApp.DAL.Interfaces;

namespace TestApp.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IApplicationDbContext _db;
        private readonly IDbSet<Category> _categories;
        public CategoryRepository(IApplicationDbContext db)
        {
            _db = db;
            _categories = db.Set<Category>();
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categories.ToListAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
