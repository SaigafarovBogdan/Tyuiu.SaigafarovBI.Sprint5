using Tyuiu.SaigafarovBI.Sprint5.Task6.V18.Lib;

namespace Tyuiu.SaigafarovBI.Sprint5.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V18.txt");
            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dataService.LoadFromDataFile(path));

            Console.ReadKey();
        }
    }
}
