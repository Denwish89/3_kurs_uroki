// Задача 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива
// Например задан масив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// 5 2 6 7

// Наименьший элемент -1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] minElemIndexes = MinElemIndexes(matrix);
int[,] newMatrix = DeliteMinRowColumn(matrix, minElemIndexes[0], minElemIndexes[1]);
PrintMatrix(newMatrix);

int[,] DeliteMinRowColumn(int[,] arrr2d, int rowDel, int columnDel)
{
    int[,] newArray = new int[arrr2d.GetLength(0) - 1, arrr2d.GetLength(1) - 1];
    int m = 0, n = 0;

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        if (m == rowDel) m++;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (n == rowDel) n++;
            newArray[i, j] = arrr2d[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newArray;
}

int[] MinElemIndexes(int[,] arr2d)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {
            if (arr2d[i, j] < arr2d[row, column])
            {
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column };
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

int Input(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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