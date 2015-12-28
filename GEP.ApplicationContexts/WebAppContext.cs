using GEP.Data.Interfaces;
using GEP.ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.ApplicationContexts
{
    public class WebAppContext : IApplicationContext
    {
        private IServiceFactory serviceFactory = null;

        public System.Security.Principal.IIdentity CurrentIdentity
        {
            get { throw new NotImplementedException(); }
        }

        public void Initialise()
        {
            this.serviceFactory = new ServiceFactory();
        }

        public IServiceFactory GetServiceFactory()
        {
            return this.serviceFactory;
        }
    }
}
