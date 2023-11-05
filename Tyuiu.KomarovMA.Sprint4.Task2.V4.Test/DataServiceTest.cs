using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint4.Task2.V4.Lib;
namespace Tyuiu.KomarovMA.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 2, 6, 4, 4, 5, 7, 3, 5, 1, 9, 9, 5 };
            int res = ds.Calculate(array);
            int wait = 44;
            Assert.AreEqual(wait, res);
        }
    }
}