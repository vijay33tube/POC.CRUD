using GEP.ServiceFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.ServiceImplementation
{
    public class ApplicationContextFactory
    {
        bool isInitialised = false;
        IApplicationContext appContext = null;

        public void InitialiseApplicationContext(IApplicationContext appContext)
        {
            this.appContext = appContext;
            isInitialised = true;
        }

        public IApplicationContext GetApplicationContext()
        {
            return this.appContext;
        }
    }
}
