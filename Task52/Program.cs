int[,] matrixArr = CreateMatrixRndInt(3, 4, 1, 10);
PrintMaxrix(matrixArr);
double[] sumElement = SumElement(matrixArr);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(sumElement);


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMaxrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("]");
    }
}

double[] SumElement(int[,] matrix)
{
    double[] sum = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum[j] += matrix[i, j];
        }
    }
    for (int i = 0; i < sum.Length; i++)
    {
        sum[i] = Math.Round(sum[i] / matrix.GetLength(1), 2);
    }

    return sum;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(']');
}