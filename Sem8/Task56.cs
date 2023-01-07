/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] matrix = Create2DArray(4, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
SummationElementString(matrix);


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

void SummationElementString(int[,] array)
{
    int summa = 0;
    int minSumma = 0;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa += array[i, j];
        }

        if (count == 0)
        {
            minSumma = summa;
            count++;
        }

        else if (summa < minSumma)
        {
            minSumma = summa;
            count++;
        }
        summa = 0;
    }
    Console.WriteLine("Строка с наименьшей суммой элементов: " + count);
}