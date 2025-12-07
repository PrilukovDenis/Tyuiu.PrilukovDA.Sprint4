using Tyuiu.PrilukovDA.Sprint4.Task2.V25.Lib;

DataService ds = new DataService();

int[] array = { 4, 6, 8, 4, 5, 6, 9, 8, 7, 4, 6 };

Console.WriteLine("Исходный массив:");
Console.WriteLine(string.Join(" ", array));

int result = ds.Calculate(array);

Console.WriteLine("Произведение четных элементов массива: " + result);

Console.ReadKey();