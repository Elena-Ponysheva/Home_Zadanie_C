/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

int[,] matrix = Create2DArray(4, 4, 1, 20);
PrintMatrix(matrix);
Console.WriteLine();
AverageSumColumn(matrix);


int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] array2D = new int[m, n];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(min, max + 1);
        }
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


double AverageSumColumn(int[,] array)
{
    double summa = 0;
    double averageSumma = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa += array[j, i];
            averageSumma = Math.Round((summa / array.GetLength(0)), 2);
        }
        Console.Write(averageSumma + " ");
        summa = 0;
    }
    return averageSumma;
}