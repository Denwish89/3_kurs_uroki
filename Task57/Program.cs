// Задача 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// image.png 

int rowMatrix = Input("Введите кол-во строк в массиве m");
int colMatrix = Input("Введите кол-во строк в массиве n");

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, 1, 10);
PrintMatrix(matrixNew);
int[] arr = MatrixToArray(matrixNew);
Array.Sort(arr);
Console.WriteLine();
PrintArray(arr);
Dictionary(arr);

void Dictionary(int[] arr)
{
    int count = 1;
    int value = arr[0];
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(value == arr[i]) count++;
        else
        {
            Console.WriteLine($"{value} ---> {count}");
            value = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{value} ---> {count}");
}

int[] MatrixToArray(int [,] matrix)
{
    int[] array = new int[matrix.Length];
    int count  = 0;    

    for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк, "0" это индекс, означает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов, "1" это индекс, означает столбцы
        {
            array[count++] = matrix[i, j];
        }
    }
    return array;
}

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}