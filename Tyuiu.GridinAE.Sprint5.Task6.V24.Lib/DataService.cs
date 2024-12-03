namespace Tyuiu.GridinAE.Sprint5.Task6.V24.Lib;

using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task6V24
{
    public int LoadFromDataFile(string path)
    {
        int count = 0;
        foreach (string word in File.ReadAllText(path).Split(' '))
        {
            if (Int32.TryParse(word, out int n) && n.ToString().Length == 5)
            {
                count++;
            }
        }
        return count;
    }
}
