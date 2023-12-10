using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint6.Task6.V25.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"D:\Project\С#\sprint\Tyuiu.BeketovVN.Sprint6\Tyuiu.BeketovVN.Sprint6.Task6.V25\bin\Debug\InPutFileTask6V25.txt";
            string wait = "ELHLVt EgQpG ZujmucpYQE";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }

    }
}
//ELHLVt EgQpG ZujmucpYQE