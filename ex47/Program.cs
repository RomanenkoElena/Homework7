// 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
Console.WriteLine($"Размер массива {m}*{n}");
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);


void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
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
