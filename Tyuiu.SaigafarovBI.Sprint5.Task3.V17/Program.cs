using Tyuiu.SaigafarovBI.Sprint5.Task3.V17.Lib;

namespace Tyuiu.SaigafarovBI.Sprint5.Task3.V17
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
            string res = dataService.SaveToFileTextData(x);

            Console.WriteLine("Файл: "+ res);
            Console.WriteLine("Создан!");


            string content = "SDNsSA2KgDNJ5ShAJN3DNA6SJ"; string newContent = "";
            foreach (char c in content)
            {
                if (!char.IsUpper(c))
                {
                    newContent += c;
                }
            }
            Console.WriteLine(String.Join("\n", newContent));
            Console.ReadKey();
        }
    }
}
