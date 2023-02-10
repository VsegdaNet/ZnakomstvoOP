Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());


int result = Akk(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} -> A(m,n) = {result}");


int Akk(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else
      if ((numM != 0) && (numN == 0))
        return Akk(numM - 1, 1);
    else
        return Akk(numM - 1, Akk(numM, numN - 1));
}
 




