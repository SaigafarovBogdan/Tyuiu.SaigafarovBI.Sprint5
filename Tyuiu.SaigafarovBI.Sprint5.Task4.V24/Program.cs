using Tyuiu.SaigafarovBI.Sprint5.Task4.V24.Lib;

namespace Tyuiu.SaigafarovBI.Sprint5.Task4.V24
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
			string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
			string path = Path.Combine(paths);
			Console.WriteLine("Данные находятся в файле: " + path);


			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");
			double res = dataService.LoadFromDataFile(path);

			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
