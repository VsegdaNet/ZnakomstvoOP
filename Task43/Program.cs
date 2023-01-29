Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");