// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = (new Random().NextDouble()) * 100;
        
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
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
double[,] resultMatrix = GetMatrix(m,n);
PrintMatrix(resultMatrix);