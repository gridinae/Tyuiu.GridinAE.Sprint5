namespace Tyuiu.GridinAE.Sprint5.Task4.V12.Test;

using Tyuiu.GridinAE.Sprint5.Task4.V12.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadFromDataFile()
    {
        Assert.AreEqual(1, new DataService().LoadFromDataFile(Path.Combine(@"C:\DataSprint5\InPutDataFileTask4V12.txt")));
    }
}