
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {number} -> ");
NaturalNumber(number);

void NaturalNumber(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    NaturalNumber(num - 1);
}


