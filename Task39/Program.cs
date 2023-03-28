// Задача 39. Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [12345] -> [54321]
// [6736] -> [6376]



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

void ReversArray(int[] arr)
{
    for(int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i]; // перестановка местами 1 - 5
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
ReversArray(array);
PrintArray(array);