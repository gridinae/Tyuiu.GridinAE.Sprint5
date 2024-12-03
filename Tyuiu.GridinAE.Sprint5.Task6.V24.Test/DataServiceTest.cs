namespace Tyuiu.GridinAE.Sprint5.Task6.V24.Test;

using Tyuiu.GridinAE.Sprint5.Task6.V24.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckFileExistence()
    {
        var path = @"C:\DataSprint5\InPutDataFileTask6V24.txt";
        Assert.IsTrue(File.Exists(path));
    }

    [TestMethod]
    public void CheckLoadFromDataFile()
    {
        var ds = new DataService();
        Assert.AreEqual(2, ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask6V24.txt"));
    }
}