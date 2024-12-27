using Tyuiu.ZainetdinovRA.Sprint5.Task2.V3.Lib;
using System.IO;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rosip\source\repos\Tyuiu.ZainetdinovRA.Sprint5\Tyuiu.ZainetdinovRA.Sprint5.Task2.V3.Lib\bin\Debug\OutPutFileTask2.csv";

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
