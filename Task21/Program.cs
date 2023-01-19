// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты");
Console.WriteLine("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ZA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Method(xa, xb, ya, yb, za, zb) ,2 ,MidpointRounding.ToZero);
Console.WriteLine($"расстояние между ними {xa}, {xb} и {ya}, {yb} и {za}, {zb} is {result}");

double Method(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distens = Math.Sqrt(Math.Pow((x2 - x1) ,2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2) );
    return distens;
}
