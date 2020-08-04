using DependencyInjection.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DataAccess.Concrete.EntityFramawork
{
    public class ExampleContext : DbContext
    {
        public ExampleContext() : base("databaseConnection")
        {
            // DatabaseInitializer’imizin çalışması için “ExampleContext” sınıfımızın constructor methoduna bu “DatabaseInitializer” sınıfımızı ekliyoruz.  
            Database.SetInitializer(new DatabaseInitializer());
        }
        public DbSet<Product> Products { get; set; }
    }
}
