using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            using (StreamWriter writer = new StreamWriter(path))
            {
                double result = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);
                writer.WriteLine(Math.Round(result, 3).ToString());
            }
            return path;
        }
    }
}
