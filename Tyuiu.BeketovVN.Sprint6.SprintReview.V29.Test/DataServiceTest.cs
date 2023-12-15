using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint6.SprintReview.V29.Lib;

namespace Tyuiu.BeketovVN.Sprint6.SprintReview.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetRandomMatrix()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            int n1 = 1;
            int n2 = 100;

            int[,] array = ds.GetRandomMatrix(n, m, n1, n2);

            for (int j = 0; j < m; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    Assert.IsTrue(array[i, j] > array[i - 1, j]);
                }
            }

        }

        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int k = 1;
            int l = 2;
            int c = 0;

            int[,] array = { { 1, 6, 7 },
                             { 7, 15, 9 },
                             { 9, 50, 20 } };

            int res = ds.GetMatrix(array, c, k, l);
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}