Console.WriteLine("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
DefineDay(dayNumber);

void DefineDay (int num)
{
    if (num > 5 & num <= 7)
    {
        Console.WriteLine("Выходной");
    }
    else if (num < 5)
    {
        Console.WriteLine("Будний");
    }
    else
    {
        Console.WriteLine("Число не подходит. Перезапустите программу");
    }
}