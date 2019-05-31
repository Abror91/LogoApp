using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Entities;

namespace TestApp.DAL.Interfaces
{
    public interface ILogoRepository : IDisposable
    {
        Task<IEnumerable<Logo>> GetLogos(int? categoryId, int? tagId, string searchString);
        Task<IEnumerable<Logo>> GetLogosByCategory(int categoryId);
        Task<IEnumerable<Logo>> GetLogosByTag(int tagId);
        Task<Logo> GetLogo(int? id);
        Task<Logo> GetLogoByName(string logoName);
    }
}
