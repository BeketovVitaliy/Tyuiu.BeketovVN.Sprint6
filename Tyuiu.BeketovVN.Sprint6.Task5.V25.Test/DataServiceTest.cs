using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint6.Task5.V25.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Project\С#\sprint\Tyuiu.BeketovVN.Sprint6\Tyuiu.BeketovVN.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";
            DataService ds = new DataService();
            double[] wait = new double[] { -17, 12, -14.32, 5, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 35, -9, 13.83, 12.76, 8.86, -1.49, -7};
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
