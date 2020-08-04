using DependencyInjection.Business.Abstract;
using DependencyInjection.DataAccess.Abstract;
using DependencyInjection.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Business.Concrete
{
    //Burada Dependency Injection Design Pattern’ni Constructor Based Dependecy Injection tekniği ile uyguluyoruz.
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> Products()
        {
            return _productDal.Products();
        }
    }

    //Eğer yukarıda yaptığım gibi dependency injection tasarım kalıbını kullanarak yaparsak “loosely coupled” yani “gevşek bağlı” bir ilişki kurarız.
}
