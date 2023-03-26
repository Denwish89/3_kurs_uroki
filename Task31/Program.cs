// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// 1. Задать массив из 12 элементов заполненный
// случайными числами из промежутка [-9, 9]
// 2. Найти сумму отрицательных и положительных элементов массива

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

void PrintArray(int[] arr) //метод вывода в консоль
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); // все элементы кроме последнего будут выводиться с запятой
        else Console.Write($"{arr[i]}"); // Последний элемент будет печататься без запятой

    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int GetSumPozitiveElem(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9); //Вызываваем метод создающий массив
PrintArray(array); //Вызываваем метод вывода в консоль

int sumNegativeElem = GetSumNegativeElem(array);
int sumPozitiveElem = GetSumPozitiveElem(array);

Console.WriteLine($"Сумма положительных элементов: {sumPozitiveElem}");
Console.WriteLine($"Сумма отрицательных элементов: {sumNegativeElem}");