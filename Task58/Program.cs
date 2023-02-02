
int[,] array2DFirst = CreateMatrixRndInt(2, 2, 1, 5);
PrintMaxrix(array2DFirst);

int[,] array2DSecond = CreateMatrixRndInt(2, 2, 1, 5);
PrintMaxrix(array2DSecond);

int[,] resultArray2D = new int[array2DFirst.GetLength(0), array2DSecond.GetLength(1)];


Console.WriteLine("Произведение двух матриц");
SummaMatrix(array2DFirst, array2DSecond, resultArray2D);
PrintMaxrix(resultArray2D);


void SummaMatrix(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}


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
    Console.WriteLine(" ");
}