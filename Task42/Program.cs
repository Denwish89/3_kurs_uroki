// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string binareCode = BinareCode(number);
Console.WriteLine(binareCode);

string BinareCode(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result += num % 2;
        num /= 2;
    }
    return result;
}
