
using Tyuiu.PrilukovDA.Sprint4.Task5.V17.Lib;

DataService ds = new DataService();

int[,] matrix = new int[5, 5]
       {
            { -5, -9, 8, 0, -2 },
            { -4, -9, -8, 3, 1 },
            { 2, 5, 4, -3, -1 },
            { -6, 0, -7, 4, -8 },
            { 1, -2, 3, -4, 2 }
       };

Console.WriteLine("Матрица 5x5:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int result = ds.Calculate(matrix);
Console.WriteLine("\nКоличество отрицательных элементов: " + result);
Console.ReadKey();

