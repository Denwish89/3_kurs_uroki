// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да 


Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);
PrintArray(array);
Console.Write("Введите число, которое будем искатьв массиве: ");
int nmbr = Convert.ToInt32(Console.ReadLine());
Console.Write(ArraySearch(array, nmbr) ? "Да" : "Нет");

void FillArray(int[] arrayValue)
{
    Random rnd = new Random();
    for(int i = 0; i < arrayValue.Length; i++)
    {
        arrayValue[i] = rnd.Next(-10, 10);
    }
}

void PrintArray(int[] arrayValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (i != arrayValue.Length - 1) Console.Write($"{arrayValue[i]}, ");
        else Console.Write($"{arrayValue[i]}\n");
    }
}

bool ArraySearch(int[] arrayValue, int nmbr)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == nmbr) return true;
        else return false;
    } 
    return false;
}