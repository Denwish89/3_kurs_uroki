// Задача 67. Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр

// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите целое положительое число");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbersDitgits = SumNumbersDitgits(number);
Console.WriteLine(sumNumbersDitgits);
int SumNumbersDitgits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumbersDitgits(num / 10);
}