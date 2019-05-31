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
    public class TagRepository : ITagRepository
    {
        private readonly IApplicationDbContext _db;
        private readonly IDbSet<Tag> _tags;
        public TagRepository(IApplicationDbContext db)
        {
            _db = db;
            _tags = db.Set<Tag>();
        }

        public async Task<IEnumerable<Tag>> GetTagsByCategory(int? categoryId)
        {
            return await _tags.Where(s => s.CategoryId == categoryId).ToListAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
