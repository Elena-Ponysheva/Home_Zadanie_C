/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);

if (b1 == k1 && b1 == k2 && b2 == k1 && b2 == k2 && k1 == k2 && b1 == b2 || k1 == k2)
{
    Console.WriteLine("Не корректные данные");
}
else
{
    Console.WriteLine("Точка пересечения: " + IntersectionPointX(b1, k1, b2, k2) + " ; " + IntersectionPointY(b1, k1, b2, k2));
}


double IntersectionPointX(double FirstAdditionalFactor, double FirstLineMultiplier, double SecondAdditionalFactor, double SecondLineMultiplier)
{
    double x = Math.Round((-(FirstAdditionalFactor - SecondAdditionalFactor) / (FirstLineMultiplier - SecondLineMultiplier)), 2);
    return x;
}

double IntersectionPointY(double FirstAdditionalFactor, double FirstLineMultiplier, double SecondAdditionalFactor, double SecondLineMultiplier)
{
    double x = IntersectionPointX(FirstAdditionalFactor, FirstLineMultiplier, SecondAdditionalFactor, SecondLineMultiplier);
    double y = Math.Round((FirstLineMultiplier * x + FirstAdditionalFactor), 2);
    return y;
}