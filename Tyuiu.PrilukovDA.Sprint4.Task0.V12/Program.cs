using Tyuiu.PrilukovDA.Sprint4.Task0.V12.Lib;

DataService ds  = new DataService();

int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

Console.WriteLine("Исходный массив:");
Console.WriteLine(string.Join(" ", array));

int result = ds.GetMultEvenArrEl(array);

Console.WriteLine("Произведение четных элементов массива: " + result);

Console.ReadKey();