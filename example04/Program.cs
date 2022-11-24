// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}

int[,,] InitMatrix(int m, int n, int p)
{
    int [,,] matrix3D = new int[m,n,p];
    Random rnd = new Random();
    int number = rnd.Next(1,20);
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                 matrix3D[i,j,k] = number;
                 number = number + rnd.Next(1,10);
            }
            
        }
    }

    return matrix3D;
}


void PrintMatrix(int [,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"({i}, {j}, {k})");
                Console.Write( $" {matrix3D[i,j,k]}; ");
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int p = GetNumber("Введите число p:");
int[,,] matrix3D = InitMatrix(m,n,p);
PrintMatrix(matrix3D);
