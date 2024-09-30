namespace Tyuiu.SaigafarovBI.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\tmppcbmbq.tmp";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}