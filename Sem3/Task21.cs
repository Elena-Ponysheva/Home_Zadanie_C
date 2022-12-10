/*
Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.WriteLine("Введите первое значение точки А");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе значение точки А");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье значение точки А");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите первое значение точки B");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе значение точки B");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье значение точки B");
int z2 = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine(AB);