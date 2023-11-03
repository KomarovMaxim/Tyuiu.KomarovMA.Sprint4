using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint4.Task1.V21.Lib;
namespace Tyuiu.KomarovMA.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 4, 2, 2, 3 };

            Assert.AreEqual(64, ds.Calculate(numsArray));
        }
    }
}