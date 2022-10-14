string[] firstArray = 
{
    "Russia", "Denmark", "England", "Bo", "Finland", "Miu"
};

int length = GetNewLength (firstArray);

int GetNewLength (string[] array)
{
  int newLength = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
     newLength++;
    }
  }
 
  return newLength;
}
