using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            double y = -0.25 * (Math.Pow(x, 3) -  3 * Math.Pow(x, 2) + 4);

            y = Math.Round(y, 3);

            byte[] result = BitConverter.GetBytes(y);

            string tempDirectory = Path.GetTempPath();
            string filePath = Path.Combine(tempDirectory, "OutPutFileTask3.bin");

            File.WriteAllBytes(filePath, result);

            return filePath;
        }
    }
}
