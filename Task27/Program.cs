// **Задача 27:**
// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.  
// 452 -> 11 
//  82 -> 1 
// 9012 -> 12

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

int sumNumber = Method(numberA);
Console.WriteLine($"{numberA} -> {sumNumber}");

int Method(int numA)
{
    int numCount = CountNumbers(numberA);
    int result = 0;

    for(int i = 0; i < numCount; i++){
        result += numA % 10;
        numA /= 10;
    }
    return result;
}


int CountNumbers(int numB)
{
    int count = 0;

    while (numB != 0)
    {
        numB = numB/10;
        count = count + 1;
    }
    return count;
}