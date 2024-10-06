using Tyuiu.SaigafarovBI.Sprint5.Task7.V26.Lib;

namespace Tyuiu.SaigafarovBI.Sprint5.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V26.txt");
            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dataService.LoadDataAndSave(path));

            Console.ReadKey();
        }
    }
}
