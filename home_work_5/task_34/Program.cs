//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите количество элементов для создания массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(count);

Console.Write("Вы задали массив: ");
PrintArray(newArray);

int evenCount = GetCountEvenElements(newArray);

Console.WriteLine($"Массив содержит {evenCount} четных элементов");

int[] GetArray(int elementCount)
{
    int[]array = new int[elementCount];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[]array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}

int GetCountEvenElements(int[]array)
{
    int count = 0;
 

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] %  2 == 0)
        {
            count++;
        }
    }
    return count;
}