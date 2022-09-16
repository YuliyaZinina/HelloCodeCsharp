// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//           и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{numberA}^{numberB} = {GetPower(numberA, numberB)}");

int GetPower(int num1, int num2)
{
    int pow = Math.Abs(num2);
    int result = 1;
    for (int i=1; i<=pow; i++)
    {
      result = result * num1;
    }
    return result;
}