// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Задайте количество строк массива (m): ");
int rowsCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов массива (n): ");
int columnsCount = Convert.ToInt32(Console.ReadLine());

double[,] newMatrix = GetArray(rowsCount, columnsCount);
PrintArray(newMatrix);

Console.WriteLine("Введите номер строки элемента массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца элемента массива: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= rowsCount && column <= columnsCount)
{
    Console.WriteLine(newMatrix[row-1, column-1]);

    // Из задания не ясно, как пользователь считает позицию элемента,
    // поэтому я решила для пользователя начинать отсчет с единицы

}
else
{
    Console.WriteLine("Такого элемента нет");
}

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