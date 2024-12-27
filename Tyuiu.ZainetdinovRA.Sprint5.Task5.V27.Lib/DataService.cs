using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string[] numbers = File.ReadAllText(path).Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var divisibleByFive = numbers
                .Select(number => int.TryParse(number.Trim(), out int result) ? result : (int?)null)
                .Where(number => number.HasValue && number.Value % 5 == 0)
                .Select(number => number.Value)
                .ToList();

            if (!divisibleByFive.Any())
            {
                throw new InvalidOperationException("Нет чисел делимых на 5.");
            }

            double average = divisibleByFive.Average();
            return Math.Round(average, 3);
        }
    }
}
