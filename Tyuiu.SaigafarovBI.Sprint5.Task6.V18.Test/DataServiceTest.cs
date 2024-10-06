using Tyuiu.SaigafarovBI.Sprint5.Task6.V18.Lib;

namespace Tyuiu.SaigafarovBI.Sprint5.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(3,dataService.LoadFromDataFile(Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V18.txt")));
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            Assert.AreEqual(true, File.Exists(Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V18.txt")));
        }
    }
}