namespace Tyuiu.GridinAE.Sprint5.Task1.V4.Test;

using Tyuiu.GridinAE.Sprint5.Task1.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        string expected = @"  x |  f(x) 
-----------
 -3 | -7,22
 -2 | -5,04
 -1 |  0
  0 | -0,3
  1 |  2,57
  2 |  6,4
  3 |  10,04
";
        CollectionAssert.AreEqual(expected.ToCharArray(), new DataService().SaveToFileTextData(-3, 3).ToCharArray());

    }
}