using DependencyInjection.DataAccess.Abstract;
using DependencyInjection.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DataAccess.Concrete.EntityFramawork
{
    public class EfProdurctDal : IProductDal
    {
        public List<Product> Products()
        {
            using (ExampleContext exampleContext = new ExampleContext())
            {
                return exampleContext.Products.ToList();
            }
        }
    }
}
