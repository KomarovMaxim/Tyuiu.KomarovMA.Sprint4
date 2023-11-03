﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint4.Task0.V8.Lib;
namespace Tyuiu.KomarovMA.Sprint4.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = {1, 6, 3, 7, 5, 4, 2, 7, 8, 9}; 
            int res = ds.GetMultEvenArrEl(numsArray);
            int a = 384;
            Assert.AreEqual(384, res);
        }
    }
}