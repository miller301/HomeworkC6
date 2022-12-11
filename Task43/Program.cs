void point(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else Console.Write($"Координаты точки пересечения заданных прямых ({x}; {y})");
}

Console.WriteLine("Введите значение b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
point(k1, b1, k2, b2);