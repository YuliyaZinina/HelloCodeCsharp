int numberM = 3;
int numberN = 2;

Console.WriteLine(Akkerman(numberM, numberN));

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m-1, 1);
    }
    else
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
}