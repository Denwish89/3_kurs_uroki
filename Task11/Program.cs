/* Задача №11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
456 -> 46 
782 -> 72 
918 -> 98 */


//Первый вариант решения без метода
/* int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int firstDigit = number / 100;
int secondDigit = number % 10;

int result = firstDigit * 10 + secondDigit;

Console.WriteLine($"Результатом будет -> {result}"); */

//Второй вариант решения с помощью метода:
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int delSecond = DelSecond(number);
Console.WriteLine($"Результатом будет -> {delSecond}");
int DelSecond(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int sumD = firstDigit * 10 + lastDigit;
    return sumD;
}

