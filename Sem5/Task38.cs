/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Размер массива, минимальное значение и максимальное значение вводим через консоль
Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()
[3 7 22 2 78] -> 76 */


Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max");
int max = int.Parse(Console.ReadLine()!);

double[] array = GenArray(size, min, max);
double diffMaxMin = DifferenceMM(array);
PrintArray(array);
Console.WriteLine(diffMaxMin);


double[] GenArray(int sizeArray, int minArray, int maxArray)
{
    double[] array = new double[sizeArray];
    for (int i = 0; i < array.Length; i++)
    {
        double number = new Random().NextDouble() * (maxArray - minArray) + minArray;
        array[i] = Math.Round(number, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DifferenceMM(double[] array)
{
    double max = 0;
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        
        else
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    double diff = max - min;

    return diff;
}