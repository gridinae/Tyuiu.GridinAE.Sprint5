namespace Tyuiu.GridinAE.Sprint5.Task3.V12.Test;

using Tyuiu.GridinAE.Sprint5.Task3.V12.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void SaveToFileTextData()
    {
        Assert.AreEqual("0,014", new DataService().SaveToFileTextData(1));
    }
}