using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ILogoRepository Logos { get; }
        ICategoryRepository Categories { get; }
        ITagRepository Tags { get; }
        Task SaveChanges();
    }
}
