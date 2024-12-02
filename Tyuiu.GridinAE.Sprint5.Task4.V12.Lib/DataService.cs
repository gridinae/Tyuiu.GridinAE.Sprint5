namespace Tyuiu.GridinAE.Sprint5.Task4.V12.Lib;

using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task4V12
{
    public double LoadFromDataFile(string path)
    {
        Double.TryParse(File.ReadAllText(path), out double x);
        double y = Math.Cos(Math.Pow(x, 3)) + x / 2;
        return y;
    }
}
