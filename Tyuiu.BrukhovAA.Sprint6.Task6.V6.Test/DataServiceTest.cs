using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrukhovAA.Sprint6.Task6.V6.Lib;

namespace Tyuiu.BrukhovAA.Sprint6.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string path = $@"C:\Users\bruho\source\repos\Tyuiu.BrukhovAA.Sprint6\Tyuiu.BrukhovAA.Sprint6.Task6.V6\bin\Debug\InPutFileTask6V6.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "YebQ HbJcPW ";
            Assert.AreEqual(wait, res);
        }
    }
}
