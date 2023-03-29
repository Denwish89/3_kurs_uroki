// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса четные, и замените эти элементы на их квадраты

// Например, изначально массив выглядел так:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4

// Новый массив будет выглядеть так:
// 1 4 49 2
// 5 9 2 3 
// 64 4 4 4

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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }

}

void ReplaceNumberToSqare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк, "0" это индекс, означает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов, "1" это индекс, означает столбцы
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}


int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceNumberToSqare(array2d);
PrintMatrix(array2d);
