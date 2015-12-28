using GEP.Core.Models;
using GEP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data
{
    public class JobDao : AbstractDao<pubsContext, job, short>, IJobDao
    {
        public List<job> GetAllByDescription(string desription)
        {
            List<job> result = null;
            using (pubsContext dbContext = GetDbContext())
            {
                result = dbContext.jobs.Where(j => j.job_desc == desription).ToList();
            }
            return result;
        }
    }
}
