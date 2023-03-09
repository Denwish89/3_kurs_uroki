/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

//Решение с методом
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool checkNum = CheckNum(number);
Console.WriteLine(checkNum ? "Да" : "Нет");

bool CheckNum(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
