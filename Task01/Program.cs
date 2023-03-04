/* Напишите программу, которая на вход принмает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет */

Console.WriteLine("Введите первое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberb = Convert.ToInt32(Console.ReadLine());

int square = numberb *numberb;

{
    if (numbera == square)
    
    Console.WriteLine("Первое число явялется квадратом второго числа");
    else
    Console.WriteLine("Первое число не явялется квадратом второго числа");
}