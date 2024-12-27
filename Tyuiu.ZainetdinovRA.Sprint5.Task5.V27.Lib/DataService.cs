using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string filePath = Path.Combine(path, "InPutDataFileTask5V27.txt");
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found at {filePath}");
            }

            string[] lines = File.ReadAllLines(filePath);
            List<int> numberDivisibleByFive = new List<int>();

            foreach (string line in lines)
            {
                if (int.TryParse(line.Trim(), out int number) && number % 5 == 0)
                {
                    numberDivisibleByFive.Add(number);
                }
            }

            if (!numberDivisibleByFive.Any())
            {
                throw new InvalidOperationException("No numbers divisible by 5 found.");
            }

            double average = numberDivisibleByFive.Average();
            return Math.Round(average, 3);
        }
    }
}
