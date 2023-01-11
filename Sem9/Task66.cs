/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите M");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int numberN = int.Parse(Console.ReadLine()!);

if (numberM > numberN)
{
    Console.WriteLine("Ошибка. Некорректные значения");    
}
else
{
    int summaMN = SummationNumbersFromMToN(numberM, numberN);
    Console.Write(summaMN);
}

int SummationNumbersFromMToN(int numberFirst, int numberSecond)
{
    if (numberFirst == numberSecond)
    {
        return numberFirst;
    }
    else
    {
        return numberFirst + SummationNumbersFromMToN(numberFirst + 1, numberSecond);
    }
}