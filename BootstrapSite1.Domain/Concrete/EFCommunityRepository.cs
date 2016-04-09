using BootstrapSite1.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapSite1.Domain.Concrete
{
    public class EFCommunityRepository : ICommunityRepository
    {
        private readonly EFDbContext context = new EFDbContext();



        public IEnumerable<Entities.Community> Communities
        {
            get { return context.Communities; }
        }
    }
}
