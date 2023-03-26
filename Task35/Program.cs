// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int[] array = CreateArrayRndInt(123, -150, 150); //Вызываваем метод создающий массив
PrintArray(array); //Вызываваем метод вывода в консоль
int arraySearch = ArraySearch(array);
Console.WriteLine($"Количество двузначных элементов массива: {arraySearch}");

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

void PrintArray(int[] arrayValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (i != arrayValue.Length - 1) Console.Write($"{arrayValue[i]}, ");
        else Console.Write($"{arrayValue[i]}\n");
    }
}

int ArraySearch(int[] arrayValue)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 10 && array[i] < 99) count++;
    } 
    return count;
}