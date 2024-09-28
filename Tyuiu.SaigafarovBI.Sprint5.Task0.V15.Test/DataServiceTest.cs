using Tyuiu.SaigafarovBI.Sprint5.Task0.V15.Lib;
using System.IO;
namespace Tyuiu.SaigafarovBI.Sprint5.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\tmp5ahsi0.tmp";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);

        }
    }
}