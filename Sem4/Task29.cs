/*
Задача 29: Напишите программу, которая принимает на вход числа n, min, max. 
Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.
5, 1, 19 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите размер масива");
int numberN =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите min");
int numberMin =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите max");
int numberMax =int.Parse(Console.ReadLine()!);

if (numberMin < numberMax)
{
    PrintArray(Array());
}
else 
{
    Console.WriteLine("Некорректный ввод данных");
}

int [] Array()
{
   int[] arr = new int [numberN];
        for (int i=0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(numberMin,numberMax+1); 
        }
        return arr;
}

void PrintArray(int [] array)
{
    for (int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}