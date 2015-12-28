using GEP.Core.Models;
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
    public class JobDaoTests
    {
        IServiceFactory factory;
        IJobDao dao;
        job obj;

        [TestInitialize]
        public void Start()
        {
            factory = ApplicationContextFactory.GetApplicationContext().GetServiceFactory();
            dao = factory.GetJobDao();

            obj = new job() { job_desc = "Manager", min_lvl = 20, max_lvl = 100 };
            dao.Add(obj);
        }

        [TestCleanup]
        public void Stop()
        {
            dao.Remove(x => x.job_id == obj.job_id);
        }

        [TestMethod]
        public void GetAllByDescriptionTest()
        {            
            List<job> result = dao.GetAllByDescription("Publisher");

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void UpdateJobTest()//best example to simulate two users working on same record
        {//set breakpoint here
            obj.min_lvl = 200;//update row for this job id in database. This is to update TimeStamp manually in database. 
            dao.Update(obj);
        }//set breakpoint here
    }
}
