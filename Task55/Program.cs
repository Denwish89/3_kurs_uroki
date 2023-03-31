// Задача 55. Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int rowMatrix = Input("Введите кол-во строк в массиве m");
int colMatrix = Input("Введите кол-во строк в массиве n");

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, 10, 70);
PrintMatrix(matrixNew);
PermutationRowAndCol(matrixNew);
Console.WriteLine();
PrintMatrix(matrixNew);

void PermutationRowAndCol(int[,] matrix1)
{
    for(int i = 0; i < matrix1.GetLength(0) - 1; i++)
    {
        for(int j = 0; j < matrix1.GetLength(1) - 1; j++)
        {
            int value = matrix1[i, j];
            matrix1[i, j] = matrix1[j, 1];
            matrix1[j, i] = value;
        }
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

int Input (string text)
{
Console. WriteLine(text);
int num =Convert.ToInt32(Console.ReadLine());
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