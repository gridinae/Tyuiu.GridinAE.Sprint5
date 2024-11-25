using Tyuiu.GridinAE.Sprint5.Task0.V7.Lib;

Console.Title = "Спринт #5 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                     *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #7                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дано выражение , вычислить его значение при x = 4, результат         *");
Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                              *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().SaveToFileTextData(4));
Console.ReadKey();