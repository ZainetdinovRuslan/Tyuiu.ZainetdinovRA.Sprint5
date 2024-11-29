using System.IO;
using System.Xml.XPath;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZainetdinovRA.Sprint5.Task0.V12.Lib
{
    public class DataService : ISprint5Task0V12
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double result = (Math.Pow(x, 3) / 2 * Math.Pow(x + 5, 2));
            result = Math.Round(result, 3);

            File.WriteAllText(path, result.ToString());
            return path;
        }
    }
}
