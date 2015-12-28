using GEP.Data.Interfaces;
using GEP.ServiceImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GEP.ApplicationContexts
{
    public class TestApplicationContext : IApplicationContext
    {
        private IServiceFactory serviceFactory = null;
        private TestContext testContext = null;

        public IIdentity CurrentIdentity
        {
            get
            {
                return WindowsIdentity.GetCurrent();
            }
        }

        public TestApplicationContext(TestContext testContext)
        {
            this.testContext = testContext;
            //Common place to change Test context settings. For example set testContext.TestResultsDirectory path etc.
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
