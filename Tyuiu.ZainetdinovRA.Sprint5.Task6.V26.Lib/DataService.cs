using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZainetdinovRA.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
            string filePath = Path.Combine(path, "InPutDataFileTask6V26.txt");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден в {filePath}");
            }

            string content = File.ReadAllText(filePath);
            int count = content.Count(c => c == '?');
            return count;
        }
    }
}
