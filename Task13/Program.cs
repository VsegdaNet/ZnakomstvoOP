// **Задача 13
// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых 
// операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num <= 100)
{
    Console.WriteLine("третьей цифры нет");
}
else{
int result = Method(num) % 10;
Console.WriteLine($"{num} -> {result}");
}

int Method(int num1)
{
    while(num1 > 1000)
    {
        num1 = num1 / 10;
    }
    return num1;
}