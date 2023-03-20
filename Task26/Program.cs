// Задача №26. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// 1. Принять на вход число
// 2. Вернуть кол-во чиселв числе

Console.Write("Введите натурально число: ");
int number = Convert.ToInt32(Console.ReadLine());
int colNumber = ColNumber(number);

Console.WriteLine($"В числе {number} содержиться {colNumber} цифр(-ы)");

int ColNumber(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num/10;
        count ++;
    }
    return count;
}
