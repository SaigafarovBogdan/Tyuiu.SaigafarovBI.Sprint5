namespace Tyuiu.SaigafarovBI.Sprint5.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            Assert.AreEqual(true, File.Exists(Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V26.txt")));
        }
    }
}