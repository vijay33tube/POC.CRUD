using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data.Interfaces
{
    public interface IApplicationContext
    {
        IIdentity CurrentIdentity { get; }
        //UserContext CurrentUser { get; }
        void Initialise();
        IServiceFactory GetServiceFactory();
    }
}
