//Задача 38: Задайте массив вещественных чисел. 
//           Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите количество элементов для создания массива: ");
int count = Convert.ToInt32(Console.ReadLine());
double[] newArray = GetArray(count);

Console.Write("Вы задали массив: ");
PrintArray(newArray);

double elementsDifference = GetMaxMinDiff(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом = {elementsDifference}");

double[] GetArray(int elementCount)
{
  double[]array = new double[elementCount];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = (new Random().NextDouble()) * 10;
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

double GetMaxMinDiff(double[]array)
{
  double maxElement = 0;
  double minElement = 10;
  
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > maxElement)
    {
      maxElement = array[i];
    }
    else if (array[i] < minElement)
    {
      minElement = array[i];
    }
  }
  Console.WriteLine($"min = {minElement}");
  Console.WriteLine($"max = {maxElement}");
  double difference = maxElement - minElement;
  return difference;
}