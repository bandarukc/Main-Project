using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapSite1.Domain.Abstract
{
    public interface IAuthentication
    {
        int Authenticate(string username, string password);
        bool Logout();
    }
}
