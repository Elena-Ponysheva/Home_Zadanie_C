/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвращает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/

Console.WriteLine("Введите первое число");
int chisloA =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int chisloB =int.Parse(Console.ReadLine()!);
Console.WriteLine(Power());

int Power()
{
    int stepenA = 1; 
    for (int i = 1; i <= chisloB; i++)
    {
        stepenA = stepenA * chisloA;
    }
    return stepenA;
}