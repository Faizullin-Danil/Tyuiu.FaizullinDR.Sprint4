using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint4.Task6.V2.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] arr = { "red", "blue", "green", "yellow" };

            string[] res = ds.Calculate(arr);

            string[] wait = { "yellow" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
