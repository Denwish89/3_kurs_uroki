// Задайте двумерный массив размером m x n,
// заполненный случайными числами.
// m = 3, n = 4/

//    0 1 2 3 
// 0  1 4 8 19
// 1  5 -2 33 -2
// 2  77 3 8 1

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // метод создающий двумерный массив через запятую [,]
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк, "0" это индекс, означает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов, "1" это индекс, означает столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }

}

int[,] array2d = CreateMatrixRndInt(3, 4,1,100);
PrintMatrix(array2d);