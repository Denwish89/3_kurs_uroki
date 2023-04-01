// Задача 65. Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int number1 = UserInput("Введите первое число: ");
int number2 = UserInput("Введите второе число: ");
NaturalNumberInterval(number1, number2);

void NaturalNumberInterval(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1}");
        NaturalNumberInterval(num1 - 1, num2);
        
    }
    if (num1 < num2)
    {
        
        NaturalNumberInterval(num1, num2 - 1);
        Console.Write($"{num2}");
    }
    if (num1 == num2)
    {
        Console.Write($"{num2}");
    }
}

int UserInput(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
