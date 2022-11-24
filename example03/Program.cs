// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InitMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,6);
        }
    }

    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [,] MatrixMultiplication( int[,] firstMatrix, int[,] secondMatrix)
{
    int [,] resultMatrix = new int[ firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = 0;

            for (int p = 0; p < firstMatrix.GetLength(1); p++)
            {
                resultMatrix[i, j] += firstMatrix[i, p] * secondMatrix[p, j];
            }
        }
    }
    return resultMatrix;
}

int firstMatrixRows = GetNumber("Введите число строк первой матрицы:");
int firstMatrixColumns = GetNumber("Введите число столбцов первой матрицы:");
int secondMatrixRows = GetNumber("Введите число строк второй матрицы:");
int secondMatrixColumns = GetNumber("Введите число столбцов второй матрицы:");
int[,] firstMatrix = InitMatrix(firstMatrixRows,firstMatrixColumns);
int[,] secondMatrix = InitMatrix(secondMatrixRows, secondMatrixColumns);
int[,] resultMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
Console.WriteLine();
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine("Произведение двух матриц");
PrintMatrix(resultMatrix);