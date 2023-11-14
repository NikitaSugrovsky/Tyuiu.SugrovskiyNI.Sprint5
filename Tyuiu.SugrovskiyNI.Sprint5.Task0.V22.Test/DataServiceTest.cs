using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SugrovskiyNI.Sprint5.Task0.V22.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint5\Tyuiu.SugrovskiyNI.Sprint5.Task0.V22\bin\Debug\OutPutFileTask0.txt.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
