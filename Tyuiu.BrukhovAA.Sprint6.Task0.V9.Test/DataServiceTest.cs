using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint6.Task0.V9.Lib;

namespace Tyuiu.BrukhovAA.Sprint6.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = -2.556;
            Assert.AreEqual(wait, res);
        }
    }
}
