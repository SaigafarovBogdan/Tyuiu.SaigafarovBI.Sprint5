namespace Tyuiu.SaigafarovBI.Sprint5.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.SaigafarovBI.Sprint5\Tyuiu.SaigafarovBI.Sprint5.Task1.V20\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}