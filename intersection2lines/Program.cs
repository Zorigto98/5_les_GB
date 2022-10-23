Console.WriteLine("Введите значения для уравнения вида y = k*x + b");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());


if (k1 - k2 != 0)
{
    if ((b2 - b1) != (k1 - k2))
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = x * k1 + b1;
        Console.WriteLine($"координаты пересечения прямых: ({x:f3}, {y:f3})");
    }
    else Console.WriteLine("Прямые совподают");
} 
else Console.WriteLine("Прямые не пересекаются");