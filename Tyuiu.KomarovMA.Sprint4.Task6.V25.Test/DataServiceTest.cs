using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint4.Task6.V25.Lib;
namespace Tyuiu.KomarovMA.Sprint4.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = new string[] { "Теннис", "Футбол", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int result = ds.Calculate(mas);
            Assert.AreEqual(2, result);
        }
    }
}