/* Задача №9 Напишите программу, которая выводит случайное 
число из отрезка [10, 99] и показывает наибольшую цифру числа. 
78 -> 8 
12-> 2 
85 -> 8
 */

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
/* int firstDigit = number / 10; //получаем первую цифру (первая слева), т.е. делим без остатка, на примере 78, это 7
int secondDigit = number % 10; // получаем вторую цифру (первая справа), т.е. при делении получаем остаток, на примере 78, это 8 */
/* if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int result = firstDigit > secondDigit ? firstDigit : secondDigit; // Если услвоие выполняется, тогда возвращаем firstDigit, иначе secondDigit
Console.WriteLine($"Наибольшая цифра числа -> {result}"); */

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num) // здесь num = number, т.е. значение из строки int maxDigit = maxDigit(number); передается в num
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}


