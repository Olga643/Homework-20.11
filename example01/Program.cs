//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InitMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = rnd.Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}  ");
        }
        Console.WriteLine();
    }
}
int[,] SortRows (int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int p = j + 1; p < matrix.GetLength(1); p++)
            {
                if (matrix[i, j] < matrix[i, p] )
                {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, p];
                matrix[i, p] = temp;
                }
            }
            
        }
    }
    return matrix;
}
Console.WriteLine("Введите кол-во строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine("----------------------");
int[,] resultMatrix = SortRows(matrix);
PrintMatrix(matrix);
