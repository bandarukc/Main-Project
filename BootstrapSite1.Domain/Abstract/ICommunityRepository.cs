using BootstrapSite1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapSite1.Domain.Abstract
{
    public interface ICommunityRepository
    {
        IEnumerable<Community> Communities { get; }
    }
}
