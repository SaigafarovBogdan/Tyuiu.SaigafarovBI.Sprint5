namespace Tyuiu.SaigafarovBI.Sprint5.Task4.V24.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void CheckedExistFile()
		{
			string path = @"C:\Users\User\AppData\Local\Temp\tmpxvaw31.tmp";
			FileInfo file = new FileInfo(path);
			Assert.AreEqual(true, file.Exists);
		}
	}
}