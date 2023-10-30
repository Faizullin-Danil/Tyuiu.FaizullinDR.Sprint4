using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint4.Task0.V6.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] arr = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

            int res = ds.GetSumOddArrEl(arr);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}
