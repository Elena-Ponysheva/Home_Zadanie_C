/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите M");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int numberN = int.Parse(Console.ReadLine()!);

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Ошибка. Некорректные значения");    
}
else
{
    Console.Write(AckermannFunction(numberM, numberN));
}


int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}