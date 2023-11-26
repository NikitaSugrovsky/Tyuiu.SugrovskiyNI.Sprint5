using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SugrovskiyNI.Sprint5.Task7.V5.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFileOutPut()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint5\Tyuiu.SugrovskiyNI.Sprint5.Task7.V5\bin\Debug\OutPutDataFileTask7V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
