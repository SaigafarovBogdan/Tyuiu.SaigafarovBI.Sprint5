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
                    bool newNumber = true;
                    for (int i  = 0; i < line.Length; i++)
                    {
                        if (!char.IsDigit(line[i]))
                        {
                            newNumber = true;
                            continue;
                        }
                        if (i == line.Length - 1) if (char.IsDigit(line[i]) && newNumber)
                        {
                                count++;
                                continue;
                        }

                        if (char.IsDigit(line[i]) && !char.IsDigit(line[i + 1]) && newNumber)
                        {
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
