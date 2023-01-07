/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] matrix = CreateSpiralArray(4, 4);
PrintMatrix(matrix);

int[,] CreateSpiralArray(int m, int n)
{
    int[,] array2D = new int[m, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array2D.GetLength(0) * array2D.GetLength(1))
    {
        array2D[i, j] = temp;
        temp++;

        if (i <= j + 1 && i + j < array2D.GetLength(1) - 1)
            j++;

        else if (i < j && i + j >= array2D.GetLength(0) - 1)
            i++;

        else if (i >= j && i + j > array2D.GetLength(1) - 1)
            j--;

        else
            i--;
    }
    return array2D;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}