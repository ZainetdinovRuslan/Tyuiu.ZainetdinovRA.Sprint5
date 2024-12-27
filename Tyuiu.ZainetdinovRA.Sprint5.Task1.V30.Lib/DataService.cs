using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task1.V30.Lib;
    public class DataService : ISprint5Task1V30
{
    public string SaveToFileTextData(int startValue, int stopValue)
    {
        StringBuilder tableBuilder = new StringBuilder();
        tableBuilder.AppendLine("x\tf(x)");
        tableBuilder.AppendLine(new string('-', 20));

        string tempDirectory = Path.GetTempPath();
        string filePath = Path.Combine(tempDirectory, "OutPutFileTask1.txt");

        for (double x = startValue; x <= stopValue; x++)
        {
            double fx;

            if (Math.Abs(2 - 2 * x) == 0) 
            {
                fx = 0;
            }
            else
            {
                fx = Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - (4 * x);
            }

            fx = Math.Round(fx, 2);

            tableBuilder.AppendLine($"{x:F1}\t{fx:F2}");
        }

        File.WriteAllText(filePath, tableBuilder.ToString());

        return filePath;
    }
}
