namespace Tyuiu.GridinAE.Sprint5.Task7.V10.Test;

using Tyuiu.GridinAE.Sprint5.Task7.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadDataAndSave()
    {
        var path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";
        var dataService = new DataService();
        var wait = "hello, мир! это is my first program.";

        Assert.AreEqual(wait, dataService.LoadDataAndSave(path));
        Assert.AreEqual(wait, File.ReadAllText(path));
    }
}