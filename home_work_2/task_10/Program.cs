Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine();
Console.WriteLine(ChooseDigitSecond(number));
  
int ChooseDigitSecond (int num)
{
int digitSecond = 0;
    if (num > 99 & num < 1000)
    {
        digitSecond =  num % 100 / 10;
    }
    else
    {
        Console.WriteLine("Число не подходит. Перезапустите программу");
    }
return digitSecond;
}
