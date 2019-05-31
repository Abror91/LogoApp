using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Interfaces;
using TestApp.DAL.Repositories;


namespace TestApp.DAL.Ninject
{
    public class NinjectInitializer : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplicationDbContext>().To<ApplicationDbContext>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ILogoRepository>().To<LogoRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<ITagRepository>().To<TagRepository>();
        }
    }
}
