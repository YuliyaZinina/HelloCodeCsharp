int numberM = 1;
int numberN = 15;

if (numberM < numberN)
{
    Console.WriteLine (Func(numberM, numberN));
}
else
{
    Console.WriteLine (Func(numberN, numberM));
}


int Func(int numFrom, int numTo)
{ 
    if (numFrom > numTo)
    {
      return 0;
    }
    else
    {
      return numFrom+ Func(numFrom+1, numTo);
    }
}