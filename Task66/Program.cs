
Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} -> {result}");


int SumNumber (int numM, int numN)
{
    if(numM == numN) return numM;
    if(numM < numN)
    {
        return SumNumber(numM + 1, numN) + numM;
    }
    if(numM > numN) 
    {
        return SumNumber(numM - 1, numN)+ numM;
    }
    else{
        return numM;
    }
}