// **Задача 25** 
//  Напишите цикл, который принимает на вход два числа (A и B) и 
//  возводит число A в натуральную степень B. 
//  3, 5 -> 243 (3⁵) 
//  2, 4 -> 16

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int b = Method(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {b}");

int Method(int numA, int numB)
{
    int res = 0;
    res = (int)Math.Pow(numA, numB);
    return res;
}