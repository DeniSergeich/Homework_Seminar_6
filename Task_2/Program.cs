// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());
if (k1 == k2)
{
    Console.WriteLine($"Прямые параллельны, пересечений нет!");
    return;
}
double[] array = GetIntersection(b1, k1, b2, k2);
Console.WriteLine($"({array[0]:f3};{array[1]:f3})");
double[] GetIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}

