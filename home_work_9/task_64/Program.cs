int numberN = 5;
Func(numberN);

int Func(int n)
{
    Console.WriteLine(n);
    if (n==1)
    {
      return 1;
    }
    else
    {
      return Func(n-1);
    }
}