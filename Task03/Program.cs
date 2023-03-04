/* 3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру
3 -> Среда
5 -> Пятница */

Console.Write("Введите номер недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Номер введен некорректно");  
}

// То же решение только с применением типа строка, т.к. у нас нет математических дейтсвий с полученным значением

Console.Write("Введите номер недели: ");
string numberday = Console.ReadLine();
switch (numberday)
{
    case "1":
        {
            Console.WriteLine("Понедельник");
            break;
        }
    case "2":
        {
            Console.WriteLine("Вторник");
            break;
        }
    case "3":
        {
            Console.WriteLine("Среда");
            break;
        }
    case "4":
        {
            Console.WriteLine("Четверг");
            break;
        }
    case "5":
        {
            Console.WriteLine("Пятница");
            break;
        }
    case "6":
        {
            Console.WriteLine("Суббота");
            break;
        }
    case "7":
        {
            Console.WriteLine("Воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine("Неверный ввод");
            break;
        }
}