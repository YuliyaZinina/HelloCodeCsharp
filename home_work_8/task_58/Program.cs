// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] D = new int[,]
{
    {2, 3, 0},
    {1, 0, 4}
};

int[,] E = new int[,]
{
    {1, 0},
    {1, 4},
    {0, 2}
};

int[,] F = GetProductMatrix (D, E);

int[,] GetProductMatrix (int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            
            for (int k = 0; k < A.GetLength(1); k++)
            {
                int productElements = A[i, k] * B[k, j];
                C[i, j] = C[i, j] + productElements;
            }
            
            Console.WriteLine(C[i, j]);
        }
    }
    return C;
}