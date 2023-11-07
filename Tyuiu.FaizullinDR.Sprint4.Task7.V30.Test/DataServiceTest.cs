using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint4.Task7.V30.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "684259137159648";

            int res = ds.Calculate(5, 3, value);

            int wait = 73728;

            Assert.AreEqual(wait, res);
        }
    }
}
