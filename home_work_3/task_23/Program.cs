
Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
GetCubeTable(number);

void GetCubeTable (int num)
{
    for (int n=1; n<=num; n++)
    {
    int cube = (int)Math.Pow(n, 3);
    Console.WriteLine($"{n}^3 = {cube}");
    }
}