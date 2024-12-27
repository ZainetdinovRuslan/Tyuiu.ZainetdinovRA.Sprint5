using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task0.V12.Lib
{
    public class DataService : ISprint5Task0V12
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2));
            string result = Math.Round(y, 3).ToString();

            string filePath = "OutPutFileTask0.txt";
            File.WriteAllText(filePath, result);

            return filePath;
        }
    }
}
