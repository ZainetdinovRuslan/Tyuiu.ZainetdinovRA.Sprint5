using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string filePath;
            if (File.Exists(path))
            {
                filePath = path; 
            }
            else
            {
                filePath = Path.Combine(path, "InPutDataFileTask5V27.txt"); 
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден в {filePath}");
            }

            string[] lines = File.ReadAllLines(filePath);
            List<int> numberDivisibleByFive = new List<int>();

            foreach (string line in lines)
            {
                Console.WriteLine($"Обрабатываемая строка: {line}");
                if (int.TryParse(line.Trim(), out int number))
                {
                    Console.WriteLine($"Обработанное число: {number}");
                    if (number % 5 == 0)
                    {
                        Console.WriteLine($"Число делимое на 5: {number}");
                        numberDivisibleByFive.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine($"Failed to parse: {line}");
                }
            }

            if (!numberDivisibleByFive.Any())
            {
                throw new InvalidOperationException("Нет чисел делимых на 5.");
            }

            double average = numberDivisibleByFive.Average();
            return Math.Round(average, 3);

            /* string filePath = Path.Combine(path, "InPutDataFileTask5V27.txt");
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден в {filePath}");
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
                throw new InvalidOperationException("Нет чисел делимых на 5.");
            }

            double average = numberDivisibleByFive.Average();
            return Math.Round(average, 3); */
        }
    }
}
