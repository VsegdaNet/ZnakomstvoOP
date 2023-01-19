// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 744 5 78 -> 7822 3 9 -> 22

Console.WriteLine("Chislo1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Chislo2");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Chislo3");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(numberA > numberB)
{
    max = numberA;
}
else{
    max = numberB;
}
if(max > numberC)
{
    max = max;
}
else{
    max = numberC;
}
Console.WriteLine($"{numberA} {numberB} {numberC} -> {max}");