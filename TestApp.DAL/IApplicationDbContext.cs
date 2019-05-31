using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Entities;

namespace TestApp.DAL
{
    public interface IApplicationDbContext : IDisposable
    {
        IDbSet<Logo> Logos { get; set; }
        IDbSet<Category> Categories { get; set; }
        IDbSet<Tag> Tags { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbSet<T> Set<T>() where T : class;
        DbEntityEntry<T> Entry<T>(T t) where T : class;
    }
}
