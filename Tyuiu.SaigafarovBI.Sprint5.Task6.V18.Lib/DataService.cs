using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SaigafarovBI.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using(StreamReader sr = new StreamReader(path))
            {
                string? line;
                while((line = sr.ReadLine()) != null)
                {
                    for(int i  = 0; i < line.Length; i++)
                    {
                        bool newNumber = true;
                        if (i == line.Length - 1) if (char.IsDigit(line[i]) && newNumber)
                        {
                                count++;
                                continue;
                        }

                        if (char.IsDigit(line[i]) && !char.IsDigit(line[i + 1]) && newNumber)
                        {
                            newNumber = true;
                            count++;
                        }
                        else newNumber = false;
                    }
                }
            }
            return count;
        }
    }
}
