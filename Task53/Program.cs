// Задача 53. Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива

void ReplaceFirstLastRows(int[,] matrix)
{
    int firstRowsIndex = 0;
    int lastRowsIndex = matrix.GetLength(1)-1;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[firstRowsIndex, i];
        matrix[firstRowsIndex, i] = matrix[lastRowsIndex, i];
        matrix[lastRowsIndex, i] = temp;
    }
}

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

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
ReplaceFirstLastRows(array2d);
Console.WriteLine();
PrintMatrix(array2d);