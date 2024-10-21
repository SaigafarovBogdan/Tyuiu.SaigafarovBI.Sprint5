using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SaigafarovBI.Sprint5.Task5.V22.Lib
{
	public class DataService : ISprint5Task5V22
	{
		public double LoadFromDataFile(string path)
		{
			double min = double.MaxValue;
			using (StreamReader sr = new StreamReader(path))
			{
				string? line;
				while ((line = sr.ReadLine()) != null)
				{
					string[] numbers = line.Split(' ');
					foreach(string number in numbers)
					{
						double number_ = double.Parse(number, CultureInfo.InvariantCulture);
						if (number_ % 4.0 == 0 && number_ < min)
						{
							min = number_;
						}
					}
				}
			}
			return Math.Round(min,3);
		}
	}
}
