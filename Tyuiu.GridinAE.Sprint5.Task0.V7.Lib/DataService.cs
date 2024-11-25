namespace Tyuiu.GridinAE.Sprint5.Task0.V7.Lib;

using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task0V7
{
    public string SaveToFileTextData(int x)
    {
        string f = Math.Round(-Math.Pow(x, 3) + 4 * x * x - 1.5 * x, 3).ToString();
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

        using (StreamWriter sw = new StreamWriter(path, false))
        {
            sw.Write(f);
        }

        return f;
    }
}
