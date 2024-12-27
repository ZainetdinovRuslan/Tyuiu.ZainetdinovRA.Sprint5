using System.Text;
using Tyuiu.ZainetdinovRA.Sprint5.Task1.V30.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string filePath = ds.SaveToFileTextData(startValue, stopValue);

            string result = File.ReadAllText(filePath);
            Console.WriteLine($"{result}");
        }
    }
}
