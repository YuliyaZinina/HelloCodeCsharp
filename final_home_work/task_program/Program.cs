string[] firstArray = 
{
    "Russia", "Denmark", "England", "Bo", "Finland", "Miu"
};

int length = GetNewLength (firstArray);
string[] newArray = CreateNewArray (firstArray, length);

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

string[] CreateNewArray (string[] array, int length)
{
  string[]newArray = new string[length];

  int newArrayIndex = 0;
    
 for (int j = 0; j < array.Length; j++)
  {
    if (array[j].Length <= 3)
    {
      newArray[newArrayIndex] = array[j];
      newArrayIndex++;
    }
  }
 
  return newArray;
}
