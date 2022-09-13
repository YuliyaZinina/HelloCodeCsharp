Console.WriteLine("Введите координаты первой точки: ");
double[] firstDoteCoordinates = GetCoordinates();
Console.WriteLine("Введите координаты второй точки: ");
double[] secondDoteCoordinates = GetCoordinates();
Console.Write("Координаты первой точки: ");
PrintCoordinates(firstDoteCoordinates);
Console.Write("Координаты второй точки: ");
PrintCoordinates(secondDoteCoordinates);
Console.WriteLine();
Console.WriteLine($"Расстояние между точками = {GetDistance(firstDoteCoordinates, secondDoteCoordinates)}");


double[] GetCoordinates()
{
    double[]coordinates = new double[3];
    for (int j = 1; j <= 3; j++)
    {
        int index = j - 1;
        Console.Write($"Введите координату {j}: ");
        coordinates[index] = Convert.ToDouble(Console.ReadLine());
    }
    return coordinates;
}

void PrintCoordinates(double[]coordinates)
{
    for (int i = 0; i < coordinates.Length; i++)
    {
        Console.Write($"{coordinates[i]} ");
    }
    Console.WriteLine();
}

double GetDistance(double[]firstCoordinates, double[]secondCoordinates)
{
    double distance = Math.Sqrt(
                                Math.Pow((secondDoteCoordinates[0] - firstDoteCoordinates[0]), 2) +
                                Math.Pow((secondDoteCoordinates[1] - firstDoteCoordinates[1]), 2) +
                                Math.Pow((secondDoteCoordinates[2] - firstDoteCoordinates[2]), 2)
                                );
    return distance; 
}