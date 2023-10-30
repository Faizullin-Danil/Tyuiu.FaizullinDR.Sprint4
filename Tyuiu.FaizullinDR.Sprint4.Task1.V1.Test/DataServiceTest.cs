﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint4.Task1.V1.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] arr = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };

            int res = ds.Calculate(arr);

            int wait = 14;

            Assert.AreEqual(wait, res);
        }
    }
}
