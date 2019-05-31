using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Interfaces;

namespace TestApp.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _db;
        private readonly ILogoRepository _logos;
        private readonly ICategoryRepository _categories;
        private readonly ITagRepository _tags;
        public UnitOfWork()
        {
            _db = new ApplicationDbContext();
            _logos = new LogoRepository(_db);
            _categories = new CategoryRepository(_db);
            _tags = new TagRepository(_db);
        }

        public ILogoRepository Logos { get { return _logos; } }
        public ICategoryRepository Categories { get { return _categories; } }
        public ITagRepository Tags { get { return _tags; } }

        public async Task SaveChanges()
        {
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _logos.Dispose();
            _categories.Dispose();
            _tags.Dispose();
        }
    }
}
