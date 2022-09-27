// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Задайте количество строк массива (m): ");
int rowsCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов массива (n): ");
int columnsCount = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = GetArray(rowsCount, columnsCount);
PrintArray(newMatrix);
Console.WriteLine();
Console.WriteLine($"Строка {GetPositionOfMinElement(GetSumElementsInRows(newMatrix))} с наименьшей суммой элементов");

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

int[] GetSumElementsInRows(int[,] matrix)
{
    int[]sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElements = sumElements + matrix[i, j];
        }

        Console.WriteLine(sumElements);
        sumArray[i] = sumElements;
    }
    return sumArray;
}

int GetPositionOfMinElement(int[]array)
{
    int minElement = array[0];
    int position = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        position = i + 1;

        if (array[i] < minElement)
        {
        minElement = array[i];
        }
    }
    return position;
}