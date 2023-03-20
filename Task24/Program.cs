// Задача №24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 ->28
// 4->10
// 8->36

// 1. Принять на вход число (А)
// 2. Выдать сумму чисел от 1 до А.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = i + sum;
    }
    return sum;
}

//Решение с возвращением строки
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

string SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    if (sum = 999) return "BINGO!!!";

    return ":(";
}