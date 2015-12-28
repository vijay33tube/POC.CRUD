using GEP.Core.Models;
using GEP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data
{
    public class EmployeeDao : AbstractDao<pubsContext, employee, string>, IEmployeeDao
    {
        public List<employee> GetByJobDescription(string jobDescription)
        {
            List<employee> result = null;
            using (pubsContext dbContext = GetDbContext())
            {
                //Sample linq query. Opportunity to write unit test
                result = (from emp in dbContext.employees
                          join j in dbContext.jobs
                          on emp.job_id equals j.job_id
                          where j.job_desc == jobDescription
                          select emp).ToList();
            }
            return result;
        }
    }
}
