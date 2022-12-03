// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine()!;
int fiest = int.Parse(input1);

Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine()!;
int second = int.Parse(input2);

if (fiest > second)
{
    Console.WriteLine("max = " + fiest);
    Console.WriteLine("min = " + second);
}
else
{
    Console.WriteLine("max = " + second); 
    Console.WriteLine("min = " + fiest);
}