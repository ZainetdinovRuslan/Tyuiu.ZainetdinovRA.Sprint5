using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден по пути {path}");
            }

            string fileContent = File.ReadAllText(path).Trim();
            double x = double.Parse(fileContent, CultureInfo.InvariantCulture);
            double y = (Math.Pow(x, 3) - 4 * x) / Math.Cos(x);

            return Math.Round(y, 3);
        }
    }
}
