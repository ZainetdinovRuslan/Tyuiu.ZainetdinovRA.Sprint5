using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZainetdinovRA.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = "OutPutFileTask2.csv";
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] row = new string[columns];
                    for (int j = 0; j < columns; j++)
                    {
                        row[j] = (matrix[i, j] % 2 != 0) ? "0" : matrix[i, j].ToString();
                    }
                    writer.WriteLine(string.Join(";", row));
                }
            }
            return path;
        }
    }
}
