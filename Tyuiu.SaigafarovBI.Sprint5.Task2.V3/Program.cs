using Tyuiu.SaigafarovBI.Sprint5.Task2.V3.Lib;

namespace Tyuiu.SaigafarovBI.Sprint5.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {5, 9, 1 },
                {1, 3, 9 },
                {1, 2, 2 }
            };
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            DataService dataService = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = dataService.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
