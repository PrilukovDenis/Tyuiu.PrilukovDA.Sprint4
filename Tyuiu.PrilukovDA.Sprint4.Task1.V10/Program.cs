using Tyuiu.PrilukovDA.Sprint4.Task1.V10.Lib;

DataService ds = new DataService();

int[] array = { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5 };

Console.WriteLine("Исходный массив:");
Console.WriteLine(string.Join(" ", array));

int result = ds.Calculate(array);

Console.WriteLine("Произведение нечетных элементов массива: " + result);

Console.ReadKey();