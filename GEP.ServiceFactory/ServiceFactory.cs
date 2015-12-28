using GEP.Data;
using GEP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.ServiceImplementation
{
    public class ServiceFactory : IServiceFactory
    {
        public IEmployeeDao GetEmployeeDao()
        {
            IEmployeeDao dao = new EmployeeDao();
            //dao.Cache >>> TODO append cache
            return dao;
        }

        public IJobDao GetJobDao()
        {
            IJobDao dao = new JobDao();
            //dao.Cache >>> TODO append cache
            return dao;
        }
    }
}
