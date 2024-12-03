namespace Tyuiu.GridinAE.Sprint5.Task5.V20.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestFileExistense()
    {
        var path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";
        Assert.AreEqual(true, File.Exists(path));
    }
}