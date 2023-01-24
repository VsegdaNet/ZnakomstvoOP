// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(']');
}

double MinimalNum(double[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       for (int j = i + 1; j < arr.Length; j++)
       {
            if(arr[i] < arr[j]) 
            {
                sum = arr[i];
            }
       }
    }
    return sum;
}

double MaxNum(double[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       for (int j = i + 1; j < arr.Length; j++)
       {
            if(arr[i] > arr[j])
            {
                sum = arr[i];
            }
       }
    }
    return sum;
}

double Difference(double min, double max)
{
    double sum = max - min;
    sum = Math.Round(sum, 1);
    return sum;
} 

double[] array = CreateArrayRndDouble(5, 1, 10);
PrintArrayDouble(array);
double res = MinimalNum(array);
double result = MaxNum(array);
double finish = Difference(res,result);
Console.Write($"-> {finish}");
