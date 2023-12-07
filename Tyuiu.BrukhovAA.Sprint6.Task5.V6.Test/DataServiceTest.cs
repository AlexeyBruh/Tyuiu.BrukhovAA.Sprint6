using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrukhovAA.Sprint6.Task5.V6.Lib;

namespace Tyuiu.BrukhovAA.Sprint6.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = $@"C:\Users\bruho\source\repos\Tyuiu.BrukhovAA.Sprint6\Tyuiu.BrukhovAA.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";


            double[] resArr;
            resArr = ds.LoadFromDataFile(path);
            double[] wait = new double[ds.len];
            wait[0] = -12;

            CollectionAssert.AreEqual(wait, resArr);
        }
    }
}
