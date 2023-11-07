using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint4.Task4.V16.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task4.V16.Test
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
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
            };
            int[,] res = ds.Calculate(arr);

            int[,] wait =
            {
                {1,1,3,1,5 },
                {1,1,3,1,5 },
                {1,1,3,1,5 },
                {1,1,3,1,5 },
                {1,1,3,1,5 },
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
