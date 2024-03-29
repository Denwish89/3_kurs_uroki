﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = CreateArrayRndInt(5, 0, 10); //Вызываваем метод создающий массив
PrintArray(array); //Вызываваем метод вывода в консоль
int[] newArray = Multiple(array);
PrintArray(newArray); //Вызываваем метод вывода в консоль

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

int[] Multiple(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0)
    {
        newArr[size - 1] = arr[arr.Length / 2];
    }
    return newArr;
}