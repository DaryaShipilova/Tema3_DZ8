// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, заданы 2 массива:  1 4 7 2     1 5 8 5
//                              5 9 2 3  и  4 9 4 2
//                              8 4 2 4     7 2 2 6
//                              5 2 6 7     2 3 4 7

// Их произведение будет равно следующему массиву:  1 20 56 10
//                                                  20 81 8 6
//                                                  56 8 4 24
//                                                  10 6 24 49

int[,] matrix1 = FillArray(4, 4, 0, 9);
int[,] matrix2 = FillArray(4, 4, 0, 9);
int[,] multiplyMatrix = FillArray(4, 4, 0, 9);

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

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


int[,] FillArray(int rowsCount, int columnsCount, int left, int right)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(left, right);
        }
    }
    return matrix;
}

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        multiplyMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
    }
}

Console.WriteLine("Произведение двух матриц:\t");
PrintArray(multiplyMatrix);
