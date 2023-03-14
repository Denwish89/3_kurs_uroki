/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */


//Решение без метода
/* Console.Write("Введите первое число кратное второму: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ostatok = number1 % number2;
if (ostatok == 0)
{
Console.WriteLine("кратно");
}
else{
Console.WriteLine($"не кратно, остаток {ostatok}");
} */

//Решение c методом
Console.Write("Введите первое число кратное второму: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Result(number1, number2);

if (result == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {result}");
}


int Result(int num1, int num2)
{
    return num1 % num2;
}