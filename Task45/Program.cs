// Задача 45. Напишите программу, которая будет создавать 
// копию заданного массива с помощью элементов поэлементного копирования

int[] array = CreateArrayRndInt(5, 1, 9); //Вызываваем метод создающий массив
int[] copyArray = ArrCopy(array);
copyArray[0] = 20;
PrintArray(array); //Вызываваем метод вывода в консоль
PrintArray(copyArray);

int[] CreateArrayRndInt(int size, int min, int max) // метод создающий массив
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] ArrCopy(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
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