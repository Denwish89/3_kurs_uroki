// Задача №28. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,1]

// 1. Сформировать массив из 8 элементов в случайном порядке состоящий из нулей и единиц
// 2. Вывести массив

int[] array = new int[8]; // формируем массив из 8 элементов (по умолчанию в пустом массиве числятся нули)

Array(array);
WriteArray(array);

void Array(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}