using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SaigafarovBI.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            if(fileInfo.Exists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Sin(i) + 3 == 0) strY = "0";
                else strY = Convert.ToString(Math.Round((5 * i + 2.5) / (Math.Sin(i) + 3) + 2 * i + Math.Cos(i), 2));

                if (i != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
            
        }
    }
}
