// **Задача 10**
// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает **вторую** цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {Method(num)}");

int Method(int num1)
{
    num1 = num1 % 100;
    num1 = num1 / 10;
    return num1;
}