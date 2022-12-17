/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Размер массива, минимальное значение и максимальное значение вводим через консоль
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max");
int max = int.Parse(Console.ReadLine()!);

int[] array = GenArray(size, min, max);
int summa = SumOfOddPositions(array);
PrintArray(array);
Console.WriteLine(summa);


int[] GenArray(int sizeArray, int minArray, int maxArray)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minArray, maxArray + 1);
    }
    return array;
}

void PrintArray(int[] array)
{ 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfOddPositions(int[] array)
{
    int summ = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        summ += array[i];
    }
    return summ;
}