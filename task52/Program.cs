int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = new Random().Next(1,1000);
        
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите колличество строк:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(m,n);

void AverMatrix(int[,]resultMatrix)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        double sr_sum = 0;
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            sr_sum = sr_sum + resultMatrix[i, j];
        }
        sr_sum = sr_sum / resultMatrix.GetLength(0);
        Console.WriteLine($"В столбце {j} среднее орифметическое равно {sr_sum}");
    }
}

PrintMatrix(resultMatrix);
AverMatrix(resultMatrix);