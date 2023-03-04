/* Напишите программу, которая на входе принимает
трехзначное число, а на выходе показывает последнюю цифру этого числа
456 -> 6
782 -> 2
918 -> 8 */

Console.Write("Введите трехзначное натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number > 99 && number < 1000)
{
    int total = number % 10;
    Console.WriteLine(total); 
}
else
{
    Console.WriteLine("Нужно ввести трехзначное натурально число");
}
