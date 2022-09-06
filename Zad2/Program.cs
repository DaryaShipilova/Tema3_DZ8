// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3 
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = FillArray(4, 4, 0, 9);
int minSum = 0;
int count = 0;

PrintArray(matrix);
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

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки равна {sum}");
    if (i == 0)
    {
        minSum = sum;
    }
    else if (sum <= minSum)
    {
        minSum = sum;
        count = i;
    }
}
Console.WriteLine($"Минимальная сумма элементов равна {minSum}");
Console.WriteLine($"Номер строки с минимальной суммой элементов - {count + 1}");

