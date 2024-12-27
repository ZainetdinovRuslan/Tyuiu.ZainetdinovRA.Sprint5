﻿using System.IO;
using Tyuiu.ZainetdinovRA.Sprint5.Task4.V27.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileInfo.Exists)
            {
                fileExists = true;
            }
            else
            {
                fileExists = false;
            }
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
