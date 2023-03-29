// Задача 48. Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Amn = m + n 
// Выведите полученный массив на экран

// m = 3, n = 4

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] CreateMatrixSumInt(int rows, int columns) // метод создающий двумерный массив через запятую [,]
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк, "0" это индекс, означает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов, "1" это индекс, означает столбцы
        {
            matrix[i, j] = i + j;
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

int[,] array2d = CreateMatrixSumInt(3, 4);
PrintMatrix(array2d);