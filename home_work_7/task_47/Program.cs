//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задайте количество строк массива (m): ");
int rowsCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов массива (n): ");
int columnsCount = Convert.ToInt32(Console.ReadLine());

double[,] newMatrix = GetArray(rowsCount, columnsCount);
PrintArray(newMatrix);

double[,] GetArray(int m, int n)
{
    double[,] matrix = new double [m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(((new Random().NextDouble()) * 10), 1);
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
            Console.Write($"{matrix[i, j]}    ");
        }
        Console.WriteLine();
    }
}