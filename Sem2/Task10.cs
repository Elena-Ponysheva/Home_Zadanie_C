//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");
int chislo =int.Parse(Console.ReadLine()!);

if (((chislo > 99) && (chislo < 1000)) || ((chislo < -99) && (chislo > -1000)))
{
    int i = chislo / 10;
    int i2 = i % 10;
    Console.WriteLine(Math.Abs(i2));
}

else
{
   Console.WriteLine("Ошибка. Некорректные данные");
}