using Tyuiu.PrilukovDA.Sprint4.Task3.V28.Lib;

DataService ds = new DataService();

int[,] array = new int[5, 5]
{
            { 5, 4, 9, 8, 5 },
            { 4, 6, 6, 9, 9 },
            { 9, 8, 4, 8, 8 },
            { 6, 8, 6, 8, 9 },
            { 9, 4, 6, 6, 7 }
};

Console.WriteLine("Исходный массив 5x5:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int result = ds.Calculate(array);

Console.WriteLine("\nМинимальный элемент в четвертом столбце: " + result);
Console.ReadKey();