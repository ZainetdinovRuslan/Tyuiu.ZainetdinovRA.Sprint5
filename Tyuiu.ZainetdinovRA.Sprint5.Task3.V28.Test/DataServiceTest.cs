using System.IO;
using Tyuiu.ZainetdinovRA.Sprint5.Task3.V28.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rosip\source\repos\Tyuiu.ZainetdinovRA.Sprint5\Tyuiu.ZainetdinovRA.Sprint5.Task3.V28.Lib\bin\Debug\OutPutFileTask3.bin";

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
