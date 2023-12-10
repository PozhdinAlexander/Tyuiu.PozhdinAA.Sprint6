using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint6.Task6.V27.Lib;
using System.IO;

namespace Tyuiu.PozhdinAA.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void test()
        {
            string path = $@"C:\Users\xMeT1oRx\source\repos\Tyuiu.PozhdinAA.Sprint6\Tyuiu.PozhdinAA.Sprint6.Task6.V27\bin\Debug\InPutFileTask6V27.txt";
            bool a = File.Exists(path);
            bool w = true;
            Assert.AreEqual(w, a);
        }
    }
}
