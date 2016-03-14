using BootstrapSite1.Domain.Abstract;
using BootstrapSite1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapSite1.Domain.Concrete
{
    public class EFProductRepository:IProductRepository
    {
        private readonly EFDbContext Context = new EFDbContext();
        public IEnumerable<Product> Products
        {

            get { return Context.Products; }
        }
    }
}
