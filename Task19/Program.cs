// **Задача 19**
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int coll =  Met1(number);
if(coll == 5)
{
  if(Met2(number) == Met3(number) && Met4(number) == Met5(number))
  {
    Console.WriteLine($"{number} -> Да");
  }
  else{
    Console.WriteLine($"{number} -> Нет");
  }
}
else{
    Console.WriteLine("Вы введи не пятизначное число");
}

int Met1 (int num1)
{
    while(num1 > 0)
    {
        i++;
        num1 = num1/10;
    }
    return i;
}

   
int Met2 (int num2) 
{
    num2 = num2 % 10;
    return num2;
}
int Met3 (int num3)
{
    num3 = num3 / 10000;
    return num3;
}
int Met4 (int num4)
{
    num4 = num4 / 1000;
    num4 = num4 % 10;
    return num4;
}
int Met5 (int num5)
{
    num5 = num5 / 10;
    num5 = num5 % 10;
    return num5;
}