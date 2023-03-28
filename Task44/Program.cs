// Задача 44. Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые 2 числа Фибоначчи: 0 и 1

// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358

Console.WriteLine("До какого числа вывести ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());

int[] FibonacciArray(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i-2];
    }
    return array;
}

int[] fibonacciArray = FibonacciArray(number);

for (int i = 0; i < number; i++)
{
    Console.Write($"{fibonacciArray[i]} ");
}