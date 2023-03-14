// Задача 22. Напишите программу, которая принимает на вход число N и выдает таблицу квадратных чисел от 1 до N.
// 5- > 1, 4, 9, 16, 25.
// 2 -> 1, 4

// 1. Задано число N
// 2. Вывести таблицу квадратных чисел от 1 до N

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    Console.WriteLine("Введено некорректное число");
}
else
{
    TableSquare(N);

    void TableSquare(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i}, {i * i}");
        }
    }
}