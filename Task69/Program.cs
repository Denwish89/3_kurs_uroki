// Задача 69. Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число A в целую степень B с помощью рекурсии

// A = 3; B = 5 -> 243 (3 в 5 степени)
// A = 2; B = 3 -> 8

int number1 = UserInput("Введите первое число: ");
int number2 = UserInput("Введите второе число: ");
int multi = MultiNumbers(number1, number2); 
Console.Write(multi);

int MultiNumbers(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return checked(num1 % 10 * MultiNumbers(num1, num2 - 1));
}

int UserInput(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}