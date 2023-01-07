/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
*/

int[,] matrixFirst = Create2DArray(2, 2, 1, 5);
PrintMatrix(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = Create2DArray(2, 2, 1, 5);
PrintMatrix(matrixSecond);
Console.WriteLine();

PrintMatrix(MultiplicationMatrix(matrixFirst, matrixSecond));


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

int[,] MultiplicationMatrix(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] arrayMult = new int[arrayFirst.GetLength(0), arrayFirst.GetLength(1)];

    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFirst.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {                
                sum += arrayFirst[i, k] * arraySecond[k, j];
            }
            arrayMult[i,j] = sum;
        }
    }
    return arrayMult;
}