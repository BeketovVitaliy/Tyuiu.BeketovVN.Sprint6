using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint6.Task1.V2.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 6.64;
            valueWaitArray[1] = 10.30;
            //valueWaitArray[2] = 41.05;
            //valueWaitArray[3] = 27.96;
            //valueWaitArray[4] = 15.48;
            //valueWaitArray[5] = 1;
            //valueWaitArray[6] = -13.06;
            //valueWaitArray[7] = -28.16;
            //valueWaitArray[8] = -42.96;
            //valueWaitArray[9] = -56.77;
            //valueWaitArray[10] = -69.83;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
//1 | 6,64 |
//| 2 | 10,30 