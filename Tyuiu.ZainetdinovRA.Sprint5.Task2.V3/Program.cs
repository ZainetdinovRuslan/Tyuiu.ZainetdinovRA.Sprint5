using System.Text;
using Tyuiu.ZainetdinovRA.Sprint5.Task2.V3.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint5.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Спринт #5 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и  *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] numbers = new int[3, 3];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            string resultMatrix = ds.SaveToFileTextData(numbers);

            string[] fileContents = File.ReadAllLines(resultMatrix);
            foreach (string file in fileContents)
            {
                Console.WriteLine(file);
            }
        }
    }
}
