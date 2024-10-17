using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SaigafarovBI.Sprint5.Task4.V24.Lib
{
	public class DataService : ISprint5Task4V24
	{
		public double LoadFromDataFile(string path)
		{
			string strX = File.ReadAllText(path);
			strX = strX.Replace('.', ',');
			double x = Convert.ToDouble(strX);
			return Math.Round((Math.Pow(x, -2) + 2) * Math.Sin(x), 3);
		}
	}
}
