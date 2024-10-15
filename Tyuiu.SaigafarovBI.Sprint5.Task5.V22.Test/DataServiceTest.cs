namespace Tyuiu.SaigafarovBI.Sprint5.Task5.V22.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void CheckedExistFile()
		{
			string path = @"C:\Users\User\AppData\Local\Temp\tmp4crf4s.tmp";
			FileInfo file = new FileInfo(path);
			Assert.AreEqual(true, file.Exists);
		}
	}
}