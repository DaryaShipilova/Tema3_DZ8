// Заполните спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int m = 4; // размерность матрицы можно изменить 
int n = 4; // но работает только на прямоуголных матрицах
int[,] matrix = new int[m, n];
int i = 0;
int j = 0;
int number = 1;

while (number <= m * n)
{
    matrix[i, j] = number;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        ++j;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        ++i;
    else if (i >= j && i + j > matrix.GetLength(1)- 1)
        --j;
    else
        --i;
    ++number;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);