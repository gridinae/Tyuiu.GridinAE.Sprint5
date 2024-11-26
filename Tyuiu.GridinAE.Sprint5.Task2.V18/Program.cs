using Tyuiu.GridinAE.Sprint5.Task2.V18.Lib;

Console.Title = "Спринт #5 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема:  Класс File. Запись структурированных данных в текстовый файл  *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #18                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный     *");
Console.WriteLine("* начениями с клавиатуры. Заменить положительные элементы массива      *");
Console.WriteLine("* на 1, отрицательные на 0. Результат сохранить в файл                 *");
Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль.                            *");
Console.WriteLine("* 3; 8; 4                                                              *");
Console.WriteLine("* -5; -4; -3                                                           *");
Console.WriteLine("* -9; 0; 2                                                             *");
Console.WriteLine("************************************************************************");

int[,] matrix = new int[3, 3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"Введите элемент №({i}, {j}): ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }

}

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().SaveToFileTextData(matrix));

Console.ReadKey();