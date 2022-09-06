// Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например: массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] matrix = FillArray(2, 2, 2, 10, 99); // числа могут повторяться (( 

PrintArray(matrix);
Console.WriteLine();

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
            Console.Write($"{matr[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] FillArray(int size1, int size2, int size3, int left, int right)
{
    int[,,] matrix = new int[size1, size2, size3];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = rand.Next(left, right);
            }
        }
    }
    return matrix;
}
