using System.IO;
using System.Text;
using Tyuiu.ZainetdinovRA.Sprint5.Task2.V3.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 5, 9, 1 },
                { 1, 3, 9 },
                { 1, 2, 2 }
            };

            ds.SaveToFileTextData(matrix);
        }
    }
}
