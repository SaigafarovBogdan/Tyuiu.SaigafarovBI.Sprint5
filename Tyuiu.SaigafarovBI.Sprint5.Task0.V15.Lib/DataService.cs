using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SaigafarovBI.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            string path = Path.Combine(paths);
            double res = Math.Round(x/(Math.Pow(x,3)+2), 3);
            File.WriteAllText(path,Convert.ToString(res));
            return path;
        }
    }
}
