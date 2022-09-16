// Задача 27: Напишите программу, которая принимает на вход число
//            и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} = {GetSumDigits(number)}");

int GetCount(int num)
{
   int count = 1;
   while (num >= 10)
   {
      num = num / 10;
      count++;
   }
   return count;
}

int GetSumDigits (int num)
{
   int digit = 0;
   int count = GetCount(num);
   int sumDigits = 0;

   while (num > 0)
   {
      digit = num % 10;
      num = num / 10;
      sumDigits = sumDigits + digit;
   }
   return sumDigits;
}