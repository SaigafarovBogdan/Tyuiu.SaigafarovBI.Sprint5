using Tyuiu.SaigafarovBI.Sprint5.Task0.V15.Lib;
namespace Tyuiu.SaigafarovBI.Sprint5.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + dataService.SaveToFileTextData(x));
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
