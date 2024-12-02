namespace Tyuiu.GridinAE.Sprint5.Task3.V12.Lib;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task3V12
{
    public string SaveToFileTextData(int x)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

        double y = Math.Round(Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2)), 3);

        using (var bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
        {
            bw.Write(y);
        }
        Console.WriteLine($"Значение выражения сохранено в файл {path}");

        using (var br = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            return br.ReadDouble().ToString();
        }
    }
}
