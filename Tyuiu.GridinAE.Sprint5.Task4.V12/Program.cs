using Tyuiu.GridinAE.Sprint5.Task4.V12.Lib;

Console.Title = "Спринт #5 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                              *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #12                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан файл в котором есть вещественное значение. Прочитать значение    *");
Console.WriteLine("* из файла и подставить вместо Х в формуле. Вычислить значение по      *");
Console.WriteLine("* формуле (Полученное значение округлить до трёх знаков после запятой) *");
Console.WriteLine("* и вернуть полученный результат на консоль.                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask4V12.txt"));
Console.ReadLine();