Console.WriteLine("Введите размерность массива:");
int i, n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

Console.WriteLine("Введите массив через пробел:");
string[] str = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
mas[i] = Convert.ToInt32(str[i]);

PrintArray(mas);
Console.Write($" -> {Positive(mas)}");


int Positive(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) result++;
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write(']');
}