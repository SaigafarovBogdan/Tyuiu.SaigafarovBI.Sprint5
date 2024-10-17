using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SaigafarovBI.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "outPutDataFileTask7V26.txt");

            if (File.Exists(pathSave)) File.Delete(pathSave);

            string strLine = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string? line;

                char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                while ((line = sr.ReadLine()) != null)
                {
                    bool newWord = false;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!letters.Contains(line[i]))
                        {
                            if (newWord)
                            {
                                strLine += "word";
                                strLine += line[i];
                                newWord = false;
                            }
                            else strLine += line[i];
                        }
                        else
                        {
                            if (i == line.Length - 1) strLine += "word";
                            newWord = true;
                        }
                    }
                    File.AppendAllText(pathSave, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSave;
        }
    }
}
