/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет */

Console.WriteLine("Введите номер строки");
int line = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца");
int column = int.Parse(Console.ReadLine()!);

int[,] newMatrix = Create2DArray(7, 8, 1, 10);
PrintMatrix(newMatrix);
Console.WriteLine();
CheckingElement(newMatrix, line, column);

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CheckingElement(int[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        Console.WriteLine(matrix[i, j]);
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}