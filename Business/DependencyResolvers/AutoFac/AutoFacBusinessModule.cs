using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        // program.cs'deki dependecy resolver işlemi Autofac'de burada gerçekleşmektedir.

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); // biri IProductService isterse ona ProductManager ver demenin AutoFac'deki karşılığı budur.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
