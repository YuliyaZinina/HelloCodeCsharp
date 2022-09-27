// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Задайте количество строк массива (m): ");
int rowsCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов массива (n): ");
int columnsCount = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = GetArray(rowsCount, columnsCount);
PrintArray(newMatrix);
Console.WriteLine();
SortRowElementsInDescending(newMatrix);
PrintArray(newMatrix);

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int [m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10, 100);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void SortRowElementsInDescending (int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = j; i < matrix.GetLength(1); i++)
            {
                int max = matrix[k, j];

                if (matrix[k, i] > max)
                {
                    max = matrix[k, i];
                    matrix[k, i] = matrix[k, j];
                    matrix[k, j] = max;
                }
            }
        }
    }
}