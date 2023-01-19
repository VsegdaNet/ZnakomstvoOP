// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее. 
// a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3

Console.WriteLine("Chislo1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Chislo1");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"Первое число {numberA}, второе число {numberB}. Максимально число {numberA} ");
}
else{
    Console.WriteLine($"Первое число {numberA}, второе число {numberB}. Максимально число {numberB} ");
}