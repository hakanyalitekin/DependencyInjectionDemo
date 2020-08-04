using DependencyInjection.Business.Abstract;
using DependencyInjection.Business.Concrete;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DependencyInjection.WebUI.Infrastructure.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory(INinjectModule ninjectModule)
        {
            _kernel = new StandardKernel(ninjectModule);
            //AddBllBindings();
        }
        //Farklı bir kullanım yöntemi https://www.youtube.com/watch?v=BZphjlMY4F8
        //public void AddBllBindings()
        //{
        //   _kernel.Bind<IProductService>().To<ProductManager>().InSingletonScope();
        //    //_kernel.Bind<IProductDal>().To<AdoNetProductDal>().InSingletonScope();
        //}
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}