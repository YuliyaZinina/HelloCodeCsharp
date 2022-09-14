// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//            и выводит их на экран.

Console.WriteLine("Введите элементы массива, состоящего из чисел: ");
double[] newArray = GetArray();
Console.Write("Вы задали массив: ");
PrintArray(newArray);

double[] GetArray()
{
    double[]array = new double[8];
    for (int i = 1; i <= 8; i++)
    {
        int index = i - 1;
        Console.Write($"Введите число {i}: ");
        array[index] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void PrintArray(double[]array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}