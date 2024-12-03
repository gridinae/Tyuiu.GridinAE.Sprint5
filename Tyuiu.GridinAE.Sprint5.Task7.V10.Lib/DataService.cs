namespace Tyuiu.GridinAE.Sprint5.Task7.V10.Lib;

using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task7V10
{
    public string LoadDataAndSave(string path)
    {
        string text = File.ReadAllText(path);
        text = text.ToLower();
        File.WriteAllText(path, text);
        return text;
    }
}
