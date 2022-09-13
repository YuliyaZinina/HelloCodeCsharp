int number = new Random().Next(10000, 100000);
//int number = 125721;
Console.WriteLine(number);
IsPalindrome(number); 

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

void IsPalindrome(int num)
{
    int digit1 = 0;
    int digit2 = 0;
    int count = GetCount(num);
    int devider = (int)Math.Pow(10, (count - 1));
    
    while (num > 10)
    {
        digit1 = (num / devider) % 10;
        digit2 = num % 10;

        num = (num - digit1 * devider) / 10;
        devider = devider / 100;

        Console.WriteLine();

        if (digit1 != digit2)
        {
            Console.WriteLine("Не палиндром");
            break;
        }
    }
    
    if (digit1 == digit2)
    {
        Console.WriteLine("Палиндром");
    }
}