// 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);
Console.WriteLine($"Размер массива {m}*{n}");

double[,] matrix = new double[m, n];
matrix = FillArray(matrix);
PrintArray(matrix);


double[,] FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double randomNum = new Random().NextDouble();
            matrix[i, j] = Math.Round(randomNum, 2);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
