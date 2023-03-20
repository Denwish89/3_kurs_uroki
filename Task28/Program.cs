// Задача №28. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// 1. Принять на вход число "N"
// 2. Вывести произведение чисел от 1 до "N"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sqNumber = SqNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {sqNumber}");

int SqNumber(int num)
{
    int sqNum = 1;
    for(int i = 1; i <= num; i++)
    {
        sqNum = i * sqNum;
    }
    return sqNum;
}
