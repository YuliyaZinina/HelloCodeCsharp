Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int min = number1;
int max = number2;

if (number1 > number2)
{
    min = number2; 
    max = number1;
}

Console.Write("Меньшее число: ");
Console.WriteLine(min);
Console.Write("Большее число: ");
Console.WriteLine(max);