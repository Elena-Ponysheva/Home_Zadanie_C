//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Отрицательные числа должны нормально работать.
// -645 -> 5
//  645 -> 5
//  78 -> третьей цифры нет
//  3261279 -> 6

Console.WriteLine("Введите число");
int chislo =int.Parse(Console.ReadLine()!);
 if (chislo > 0)
 {
        string chisloText = Convert.ToString(chislo);
        if (chisloText.Length > 2)
        {
            Console.WriteLine("Третья цифра = " + chisloText[2]);
        }
        else 
        {
            Console.WriteLine("Третья цифра отсутствует");
        }
}

else
{
    int chisloPol = chislo * -1;
    string chisloPolText = Convert.ToString(chisloPol);
        if (chisloPolText.Length > 2)
        {
            Console.WriteLine("Третья цифра = " + chisloPolText[2]);
        }
        else 
        {
            Console.WriteLine("Третья цифра отсутствует");
        }
}