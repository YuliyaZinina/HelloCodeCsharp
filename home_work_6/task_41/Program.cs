//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов для создания массива: ");
int arrayLenght = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите элементы массива, состоящего из {arrayLenght} чисел: ");
int[] newArray = GetArray(arrayLenght);

Console.Write("Вы задали массив: ");
PrintArray(newArray);

Console.Write("Чисел больше нуля: ");
Console.WriteLine(GetPositiveNumberCount(newArray));

int[] GetArray(int M)
{
    int[]array = new int[M];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int GetPositiveNumberCount(int[]array)
{
    int posCount = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0)
        {
            posCount = posCount + 1;
        }
    }
    return posCount;
}