// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
//  1 4 7 2       1 2 4 7
//  5 9 2 3  -->  2 3 5 9
//  8 4 2 4       2 4 4 8

Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillRndArray(matrix);
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillRndArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] > matrix[i, k + 1])
            {
                int temp = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = temp;
            }
        }
    }
}

Console.WriteLine();
PrintArray(matrix);