// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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

Console.WriteLine("Введите позицию в строке:");
int PositionX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию в столбце:");
int PositionY = Convert.ToInt32(Console.ReadLine());

if (PositionX > m || PositionY > n)
{
    Console.WriteLine("Число отсутствует");
}
else
{
    Console.WriteLine($"Под данным индексами находится число :{resultMatrix[PositionX,PositionY]}");
}
PrintMatrix(resultMatrix);