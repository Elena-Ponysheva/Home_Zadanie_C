// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine()!;
int fiest = int.Parse(input1);

Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine()!;
int second = int.Parse(input2);

Console.WriteLine("Введите третье число");
string input3 = Console.ReadLine()!;
int third = int.Parse(input3);

if (fiest > second && fiest>third) 
{
    Console.WriteLine("max = " + fiest );
}
    
else 
    if (second > third)
    {
        Console.WriteLine("max = " + second );
    }
    else 
    {
        Console.WriteLine("max = " + third);
    }