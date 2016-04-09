using BootstrapSite1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapSite1.Models
{
    public class CommunityListViewModel
    {
        public IEnumerable<Community> Communities { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}