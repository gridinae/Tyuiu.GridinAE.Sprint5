using Tyuiu.GridinAE.Sprint5.Task7.V10.Lib;

Console.Title = "Спринт #5 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #10                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан файл в котором есть набор символьных данных.                     *");
Console.WriteLine("* Заменить все заглавные латинские буквы на строчные.                  *");
Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V10.txt.    *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V10.txt"));
Console.ReadKey();