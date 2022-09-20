// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты уравнений (b1, k1, b2, k2): ");
int[] newArray = GetСoefficientArray();

GetResult(newArray);

int[] GetСoefficientArray()
{
    int[]array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void GetResult(int[]array)
{
    double determinantMain = array[3]-array[1];
    if (determinantMain == 0)
    {
        Console.WriteLine("Прямые совпадают или параллельны");
    }
    else
    {
        double determinantX = array[0] - array[2];
        double determinantY = array[3]*array[0] - array[1]*array[2];

        double coordinateX = determinantX / determinantMain;
        double coordinateY = determinantY / determinantMain;

        Console.WriteLine($"Прямые пересекаются в точке с координатами ({coordinateX}, {coordinateY})");
    }
}