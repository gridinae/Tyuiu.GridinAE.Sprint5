namespace Tyuiu.GridinAE.Sprint5.Task2.V18.Lib;

using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task2V18
{
    public string SaveToFileTextData(int[,] matrix)
    {

        string output = string.Empty;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                output += (matrix[i, j] <= 0 ? "0" : "1") + ",";
            }
            output += matrix[i, matrix.GetLength(1) - 1] + Environment.NewLine;
        }

        output = output.TrimEnd();
        using (var sw = new StreamWriter(Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv")))
        {
            sw.Write(output);
        }

        return output;
    }
}
