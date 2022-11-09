// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет

int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
Console.WriteLine($"Исходный массив {row}*{column}");

int[,] matrix = new int[row, column];
matrix = FillArray(matrix);
PrintArray(matrix);

Console.Write("Введите номер строки (нумерация начинается с нуля): ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца(нумерация начинается с нуля): ");
int j = Convert.ToInt32(Console.ReadLine());

if (i < 0 | i > matrix.GetLength(0) - 1 | j < 0 | j > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента в массиве не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[i, j]);
}

int[,] FillArray(int[,] matrix) // метод заполнения массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix) // метод печати массива
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

