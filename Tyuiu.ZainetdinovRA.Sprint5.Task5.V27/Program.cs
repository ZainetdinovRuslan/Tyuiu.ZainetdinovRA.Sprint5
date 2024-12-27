using Tyuiu.ZainetdinovRA.Sprint5.Task5.V27.Lib;
using System.Text;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в    *");
            Console.WriteLine("* котором есть набор значений. Найти среднее значение всех целых чисел в  *");
            Console.WriteLine("* файле, которые делятся на 5. Полученный результат вывести на консоль. У *");
            Console.WriteLine("* вещественных значений округлить до трёх знаков после запятой.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            string filePath = @"C:\DataSprint5\InPutDataFileTask5V27.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double average = ds.LoadFromDataFile(filePath);
                Console.WriteLine($"Среднее значение всех целых чисел, которые делятся на 5: {average}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
            }
        }
    }
}
