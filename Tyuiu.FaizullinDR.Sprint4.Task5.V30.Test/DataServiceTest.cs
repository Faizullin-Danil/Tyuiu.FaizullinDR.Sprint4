using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint4.Task5.V30.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] arr =
            {
                {-2,-1,0,1,2 },
                {-2,-1,0,1,2 },
                {-2,-1,0,1,2 },
                {-2,-1,0,1,2 },
                {-2,-1,0,1,2 }
            };

            int res = ds.Calculate(arr);

            Assert.AreEqual(15, res);


        }
    }
}
