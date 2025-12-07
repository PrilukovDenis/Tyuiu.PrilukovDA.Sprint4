using Tyuiu.PrilukovDA.Sprint4.Task7.V10.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Прилуков Д.А. | НТм-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Прилуков Денис Алексеевич | НТм-24-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать консольную программу на C#                                      *");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите value: ");
string value = Convert.ToString(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(n, m, value));