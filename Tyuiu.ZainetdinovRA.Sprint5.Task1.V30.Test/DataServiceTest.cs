using System.IO;

using Tyuiu.ZainetdinovRA.Sprint5.Task1.V30.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rosip\source\repos\Tyuiu.ZainetdinovRA.Sprint5\Tyuiu.ZainetdinovRA.Sprint5.Task1.V30.Lib\bin\Debug\OutPutFileTask1.txt";

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
