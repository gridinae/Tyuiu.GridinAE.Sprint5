namespace Tyuiu.GridinAE.Sprint5.Task2.V18.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        Assert.AreEqual(true, File.Exists(Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv")));
    }
}