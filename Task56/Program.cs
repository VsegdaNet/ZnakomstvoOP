
int[,] array2D = CreateMatrixRndInt(5, 3, 1, 8);
PrintMaxrix(array2D);

int minSuma = 0;
int sumeliment = SumArray(array2D, 0);

for (int i = 1; i < array2D.GetLength(0); i++)
{
  int tempArr = SumArray(array2D, i);
  if (sumeliment > tempArr)
  {
    sumeliment = tempArr;
    minSuma = i;
  }
}
Console.WriteLine($"{minSuma+1} -> на этой строке самая маленькая сумма = ({sumeliment})");


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

int SumArray(int[,] array, int i)
{
    int sumeliment = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumeliment += array[i, j];
    }
    return sumeliment;
}