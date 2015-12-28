using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data.Interfaces
{
    public partial interface IServiceFactory
    {
        IEmployeeDao GetEmployeeDao();
        IJobDao GetJobDao();
    }
}
