namespace Tyuiu.GridinAE.Sprint5.Task5.V20.Lib;

using tyuiu.cources.programming.interfaces.Sprint5;
public class DataService : ISprint5Task5V20
{
    public double LoadFromDataFile(string path)
    {
        double res = 0;
        double count = 0;
        using (var sr = new StreamReader(path))
        {
            string[] numbers = sr.ReadToEnd().Split(' ');
            count = numbers.Length;
            foreach(string number in numbers)
            {
                if (Int32.TryParse(number, out int n) && -10 <= n && n <= 10)
                {
                    res += n;
                }       
            }
        }
        return Math.Round(res / count, 3);
    }
}
