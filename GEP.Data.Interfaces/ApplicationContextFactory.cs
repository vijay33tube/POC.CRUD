using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data.Interfaces
{
    //Initialize per Http request
    public static class ApplicationContextFactory
    {
        private static bool isInitialised = false;
        private static IApplicationContext context = null;

        public static void InitialiseApplicationContext(IApplicationContext appContext)
        {
            context = appContext;
            appContext.Initialise();
            isInitialised = true;
        }

        public static IApplicationContext GetApplicationContext()
        {
            if (!isInitialised)
                throw new InvalidOperationException("Context is not initialised");

            return context;
        }
    }
}
