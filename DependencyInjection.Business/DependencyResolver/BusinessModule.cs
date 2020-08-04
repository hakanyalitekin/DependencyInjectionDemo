using DependencyInjection.Business.Abstract;
using DependencyInjection.Business.Concrete;
using DependencyInjection.DataAccess.Abstract;
using DependencyInjection.DataAccess.Concrete.AdoNet;
using DependencyInjection.DataAccess.Concrete.EntityFramawork;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Business.DependencyResolver
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<AdoNetProductDal>().InSingletonScope();

            /*
             “BusinessModule” adlı class’ımızı “NinjectModule” abstract class’ından implemente ederek Load methodunu override ediyoruz. 
            Load methodumuz içerisinde “IProductService” ile “ProductManager” ‘ı “IProductDal” ile de “EfProductDal” ‘ı birbirine bağlıyoruz.
            Yani “IProductService” talebinde bulunulursa “ProductManager” instance’nı oluştur eğer
            “IProductDal” talebinde bulunulursa ise “EfProductDal” instance’nı oluştur diyoruz. 
            InSingletonScope() methodu ile de bu nesnelerin tek bir defa üretilmesini sağlıyoruz.
            */
        }
    }
}
