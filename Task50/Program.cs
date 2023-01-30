
Console.WriteLine("Введите координаты");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
if (numA < 0 || numB < 0)
{
    Console.WriteLine("Некорректно введено число");
}
else
{

int[,] matrixArr = CreateMatrixRndInt(4, 4, 1, 20);
PrintMaxrix(matrixArr);
ExaminationNum(matrixArr, numA, numB);


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

    void ExaminationNum(int[,] matr, int num1, int num2)
    {
        int result = 0;
        if (matr.GetLength(0) < num1 && matr.GetLength(1) < num2)
        {
            Console.WriteLine($"{num1} , {num2} - Такого элемента нет");
        }
        else
        {
            result = matr[num1, num2];
            Console.WriteLine($"{result}");
        }
    }

}


