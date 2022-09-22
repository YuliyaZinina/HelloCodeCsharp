//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Задайте количество строк массива (m): ");
int rowsCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов массива (n): ");
int columnsCount = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = GetArray(rowsCount, columnsCount);
PrintArray(newMatrix);
Console.WriteLine();
GetAverageArrayColumn(newMatrix);


int[,] GetArray(int m, int n)
{
    int[,] matrix = new int [m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100);
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

void GetAverageArrayColumn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sumElements = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumElements = sumElements + matrix[j, i];
        }

        double average = Math.Round((sumElements / matrix.GetLength(0)), 2);
        Console.WriteLine(average);    
    }
}