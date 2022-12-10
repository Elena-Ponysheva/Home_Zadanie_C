/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Vvedite 5-oe shislo");
int number = int.Parse(Console.ReadLine()!);
if (number < 0)
{
    number = -number;
}
    if (number > 9999 && number < 100000)
    {
        int c1 = number / 10000;
        int c5 = number % 10;
        int c2 = number / 1000 % 10;
        int c4 = number / 10 % 10;

            if (c1 == c5 && c2 == c4)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Ne Palindrom");
            }
    }
    else
    {
        Console.WriteLine("Oshibka. Vvedite 5-oe shislo");
    }