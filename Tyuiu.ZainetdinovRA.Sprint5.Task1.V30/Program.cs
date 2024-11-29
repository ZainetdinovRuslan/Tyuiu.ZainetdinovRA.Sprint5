using System.Text;
using Tyuiu.ZainetdinovRA.Sprint5.Task1.V30.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint5.Task1.V30
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
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
            Console.WriteLine("* значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и  *");
            Console.WriteLine("* вывести на консоль в таблицу. Значения округлить до двух знаков после   *");
            Console.WriteLine("* запятой.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            int range = Math.Abs(startValue - stopValue) + 1;
            string result = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            string[] fileContents = File.ReadAllLines(result);
            for (int i = startValue; i <= stopValue; i++)
            {
                Console.WriteLine($"{i} = {fileContents[i - startValue]}");
            }

        }
    }
}
