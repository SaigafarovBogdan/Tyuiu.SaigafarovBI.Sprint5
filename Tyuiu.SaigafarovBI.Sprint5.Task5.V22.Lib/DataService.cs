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
					double number = Convert.ToDouble(line);
					if (number % 4.0 == 0 && number < min)
					{
						min = Convert.ToDouble(line);
					}
				}
			}
			return Math.Round(min,3);
		}
	}
}
