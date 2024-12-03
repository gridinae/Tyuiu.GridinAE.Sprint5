using Tyuiu.GridinAE.Sprint5.Task6.V24.Lib;

Console.Title = "Спринт #5 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Обработка текстовых файлов                                     *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #24                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан файл в котором есть набор символьных данных.                     *");
Console.WriteLine("* Найти количество пятизначных чисел в заданной строке.                *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask6V24.txt"));
Console.ReadKey();