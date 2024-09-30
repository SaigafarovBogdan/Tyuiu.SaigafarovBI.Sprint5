using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SaigafarovBI.Sprint5.Task3.V17.Lib
{
    public class DataService : ISprint5Task3V17
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            string path = Path.Combine(paths);

            double result = Math.Round(2.4 * x * x * x + 0.4 * x * x - 1.4 * x + 4.1,3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(result));
            }
            return path;
        }
    }
}
