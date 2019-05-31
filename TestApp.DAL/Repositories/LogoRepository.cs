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
    public class LogoRepository : ILogoRepository
    {
        private readonly IApplicationDbContext _db;
        private readonly IDbSet<Logo> _logos;
        public LogoRepository(IApplicationDbContext db)
        {
            _db = db;
            _logos = db.Set<Logo>();
        }

        public async Task<IEnumerable<Logo>> GetLogos(int? categoryId, int? tagId, string searchString)
        {
            IEnumerable<Logo> logos = null;
            if(categoryId != null && tagId != null)
            {
                logos = await _logos.Include(s => s.Category).Where(s => s.CategoryId == categoryId && s.Tags.Any(p => p.Id == tagId)).ToListAsync();
            }
            else if(categoryId != null)
            {
                logos = await _logos.Include(s => s.Category).Where(s => s.CategoryId == categoryId).ToListAsync();
            }
            else if (!string.IsNullOrWhiteSpace(searchString))
            {
                logos = await _logos.Include(s => s.Category).Where(s => s.CompanyName.ToLower().Contains(searchString.ToLower())).ToListAsync();
            }
            else
            {
                logos = await _logos.Include(s => s.Category).ToListAsync();
            }
            return logos;
        }

        public async Task<IEnumerable<Logo>> GetLogosByCategory(int categoryId)
        {
            return await _logos.Where(s => s.CategoryId == categoryId).ToListAsync();
        }

        public async Task<IEnumerable<Logo>> GetLogosByTag(int tagId)
        {
            return await _logos.Where(s => s.Tags.Any(p => p.Id == tagId)).ToListAsync();
        }

        public async Task<Logo> GetLogo(int? id)
        {
            return await _logos.Include(s => s.Category).Include(s => s.Tags).Where(s => s.Id == id).SingleOrDefaultAsync();
        }

        public async Task<Logo> GetLogoByName(string logoName)
        {
            return await _logos.Where(s => s.CompanyName == logoName).SingleOrDefaultAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
