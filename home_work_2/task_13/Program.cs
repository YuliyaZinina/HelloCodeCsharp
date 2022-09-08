Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

Console.WriteLine(ChooseThirdDigit(number));

char ChooseThirdDigit (string num)
{
    char thirdDigit = 't';
    if (num.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
    thirdDigit = num[2];
    }
    return thirdDigit;
}
