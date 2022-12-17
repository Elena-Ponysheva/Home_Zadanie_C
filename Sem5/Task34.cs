/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
Размер массива вводим через консоль
[345, 897, 568, 234] -> 2 */



Console.WriteLine("Введите размер массива");

int sizeArray = int.Parse(Console.ReadLine()!);
int[] array = GenArray(sizeArray);
int positiveNumber = СounterPositiveNumber(array);

PrintArray(array);
Console.WriteLine(positiveNumber);


int[] GenArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int СounterPositiveNumber(int[] array)
{
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}