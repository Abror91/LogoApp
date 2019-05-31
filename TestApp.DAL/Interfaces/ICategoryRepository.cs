using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Entities;

namespace TestApp.DAL.Interfaces
{
    public interface ICategoryRepository : IDisposable
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
