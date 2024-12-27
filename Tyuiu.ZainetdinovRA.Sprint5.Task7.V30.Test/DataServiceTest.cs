namespace Tyuiu.ZainetdinovRA.Sprint5.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V30.txt";

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
