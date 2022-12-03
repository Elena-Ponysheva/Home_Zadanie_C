// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int chislo =int.Parse(Console.ReadLine()!);

if ((chislo > 0) && (chislo < 8))
{
    if ((chislo==6) || (chislo==7))
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будни");
    }
}

else
{
    Console.WriteLine("Ошибка. Некорректные данные");
}