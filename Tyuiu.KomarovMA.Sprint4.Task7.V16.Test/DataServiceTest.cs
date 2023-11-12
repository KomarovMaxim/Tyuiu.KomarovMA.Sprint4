using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint4.Task7.V16.Lib;
namespace Tyuiu.KomarovMA.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int rows = 5;
            int column = 3;
            string str = "382976421897948";
            int res = ds.Calculate(rows, column, str);
            int wait = 196608;
            Assert.AreEqual(wait, res);
        }
    }
}
