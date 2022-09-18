//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//           Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите количество элементов для создания массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(count);

Console.Write("Вы задали массив: ");
PrintArray(newArray);

int sumOddIndexElements = GetSumOddIndexElements(newArray);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {sumOddIndexElements}");

int[] GetArray(int elementCount)
{
  int[]array = new int[elementCount];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-100, 1000);
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

int GetSumOddIndexElements(int[]array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 == 1)
    {
      sum = sum + array[i];
    }
  }
  return sum;
}