using GEP.ApplicationContexts;
using GEP.Data.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data.Tests
{
    [TestClass]
    class TestConfig
    {
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            ApplicationContextFactory.InitialiseApplicationContext(new TestApplicationContext(context));
        }
    }
}
