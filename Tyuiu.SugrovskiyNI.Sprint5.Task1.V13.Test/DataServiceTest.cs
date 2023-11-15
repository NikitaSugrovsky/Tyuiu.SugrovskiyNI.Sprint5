using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint5.Task1.V13.Lib;
using System.IO;

namespace Tyuiu.SugrovskiyNI.Sprint5.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint5\Tyuiu.SugrovskiyNI.Sprint5.Task1.V13.Test\bin\Debug\OutPutFileTask1.txt.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
