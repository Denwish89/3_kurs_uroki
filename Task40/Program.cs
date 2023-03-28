// Задача 40. Напишите программу, которая принимает на вход три числа,
// и проверяет может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон

// 1. Принимаем на вход 3 числа
// 2. Проверяем может ли существовать треугольник со сторонами такой длины

Console.Write("Введите длину первой стороны: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину второй стороны: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину третьей стороны: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(number1, number2, number3)? "Да" : "Нет");

bool CheckTriangle(int number1, int iumber2, int number3)
{
    if(number1 < number2 + number3)
    {
        if(number2 < number1 + number3)
        {
            if(number3 < number1 + number2) return true;
            else return false;
        }
        else return false;
    }
    else return false;
}
