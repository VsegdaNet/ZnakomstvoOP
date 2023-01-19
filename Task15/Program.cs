// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите День недели");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 8)
{
     if(num >= 6)
     {
        Console.WriteLine($"{num} -> да");
     }
    else{
        Console.WriteLine($"{num} -> нет");
    }

}
else {
    Console.WriteLine("Такого дня недели нет");
}