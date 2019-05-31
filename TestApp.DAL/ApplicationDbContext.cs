using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Entities;

namespace TestApp.DAL
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
        public IDbSet<Logo> Logos { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
        public new DbEntityEntry Entry<T>(T t) where T : class
        {
            return base.Entry(t);
        }
    }
}
