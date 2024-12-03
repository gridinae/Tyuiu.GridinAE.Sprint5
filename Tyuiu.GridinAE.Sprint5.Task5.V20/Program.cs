using Tyuiu.GridinAE.Sprint5.Task5.V20.Lib;

Console.Title = "Спринт #5 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                       *");
Console.WriteLine("* Задание #5                                                           *");
Console.WriteLine("* Вариант #20                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан файл в котором есть набор значений. Найти среднее значение       *");
Console.WriteLine("* всех целых чисел в файле, которые находятся в промежутке             *");
Console.WriteLine("* от -10 до 10. Полученный результат вывести на консоль.               *");
Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask5V20.txt"));
Console.ReadLine();