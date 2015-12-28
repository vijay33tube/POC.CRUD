using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GEP.Data.Interfaces;
using GEP.Core.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace GEP.Data.Tests
{
    [TestClass]
    public class EmployeeDaoTests
    {
        [TestInitialize]
        public void Start()
        {
            //set up data
        }

        [TestCleanup]
        public void Stop()
        {
            //delete set up data
        }

        [TestMethod]
        public void FirstTest()
        {
            int expectedjobId = 10;

            IServiceFactory factory = ApplicationContextFactory.GetApplicationContext().GetServiceFactory();
            IEmployeeDao employeeDao = factory.GetEmployeeDao();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            employee result = employeeDao.First(e => e.job_id == 10);

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedjobId, result.job_id);
        }

        [TestMethod]
        public void GetByJobIDTest()
        {
            IServiceFactory factory = ApplicationContextFactory.GetApplicationContext().GetServiceFactory();
            IEmployeeDao employeeDao = factory.GetEmployeeDao();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<employee> result = employeeDao.GetByJobDescription("Publisher");

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

    }
}
