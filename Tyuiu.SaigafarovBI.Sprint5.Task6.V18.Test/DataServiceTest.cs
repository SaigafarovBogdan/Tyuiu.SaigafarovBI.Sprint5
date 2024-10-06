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
            Assert.AreEqual(10,dataService.LoadFromDataFile(Path.Combine(Path.GetTempPath(), Path.GetTempFileName())));
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            Assert.AreEqual(true, File.Exists(Path.Combine(Path.GetTempPath(), Path.GetTempFileName())));
        }
    }
}