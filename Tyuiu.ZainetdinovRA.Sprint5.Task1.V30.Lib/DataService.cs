using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            int range = Math.Abs(startValue - stopValue) + 1;
            double[] arrValues = new double[range];

            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = 2 - (2 * i);
                double resultOfFunction;
                if (denominator == 0)
                {
                    resultOfFunction = 0;
                } 
                else
                {
                    resultOfFunction = Math.Round(Math.Cos(i) + (Math.Sin(i) / denominator) - (4 * i), 2);
                }
                arrValues[i - startValue] = resultOfFunction;
            }
            File.WriteAllText(path, string.Join('\n', arrValues));
            return path;
        }
    }
}
