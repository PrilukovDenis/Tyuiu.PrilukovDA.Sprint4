using Tyuiu.PrilukovDA.Sprint4.Task4.V24.Lib;

DataService ds = new DataService();

int[,] matrix = new int[5, 5]
{
            { 7, 9, 7, 6, 7 },
            { 9, 9, 8, 6, 7 },
            { 8, 6, 5, 6, 7 },
            { 9, 9, 7, 8, 7 },
            { 5, 9, 9, 8, 9 }
};

Console.WriteLine("Исходный массив 5x5:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Исправленный массив 5x5:");

int[,] result = ds.Calculate(matrix);

int rows = result.GetLength(0);
int cols = result.GetLength(1);


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();