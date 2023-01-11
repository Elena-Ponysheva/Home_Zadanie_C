/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine()!);

if (numberN < 1)
{
    Console.WriteLine("Ошибка. Некорректное значение");
}
else
{
    Console.Write(OutputNumbersFromN(numberN));
}

string OutputNumbersFromN(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    else
    {
        return number.ToString() + ", " + OutputNumbersFromN(number - 1);
    }
}