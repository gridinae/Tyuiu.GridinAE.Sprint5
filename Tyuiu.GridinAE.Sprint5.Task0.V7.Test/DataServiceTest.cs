namespace Tyuiu.GridinAE.Sprint5.Task0.V7.Test;

using Tyuiu.GridinAE.Sprint5.Task0.V7.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        Assert.AreEqual("1,5", new DataService().SaveToFileTextData(1));
    }
}