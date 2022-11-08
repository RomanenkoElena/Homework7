// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int row = new Random().Next(1, 5);
int column = new Random().Next(1, 5);
Console.WriteLine($"Размер массива {row}*{column}");
int[,] matrix = new int[row, column];
FillArray(matrix);
PrintArray(matrix);
AverageNum(matrix);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
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

void AverageNum(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
        }
        result = sum/matrix.GetLength(0);
   // Console.Write($"Среднее арифм-е каждого столбца:|{String.Join("|", result)}|");
    Console.WriteLine($"Среднее арифм-е каждого столбца: {Math.Round(result, 2)}");
    }
}