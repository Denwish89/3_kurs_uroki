// Задача 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x, y).

// 1. Задан номер четверти
// 2. диапазон возможных координат точек в этой четверти (x, y)

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string coordinate = Coordinate(quarter);

Console.WriteLine(coordinate);

string Coordinate(int Quarter)
{
    if(Quarter == 1) return "x > 0, y > 0";
    if(Quarter == 2) return "x < 0, y > 0";
    if(Quarter == 3) return "x < 0, y < 0";
    if(Quarter == 4) return "x > 0, y < 0";
    return "Введена некорректная четверть";
}

