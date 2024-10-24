﻿using Tyuiu.SaigafarovBI.Sprint5.Task5.V22.Lib;
using System.Globalization;

namespace Tyuiu.SaigafarovBI.Sprint5.Task5.V22
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService dataService = new DataService();
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");
			string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
			Console.WriteLine("Данные находятся в файле: " + path);


			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");
			double res = dataService.LoadFromDataFile(path);

			Console.WriteLine("Минимальный элемент кратный 4: " + res);
			Console.ReadKey();
		}
	}
}
