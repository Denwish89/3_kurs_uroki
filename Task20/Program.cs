// Задача 20. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату первой точки x: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату второй точки x: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());

double coordinate = lenght(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
Console.WriteLine(coordinate);

double lenght(int x1, int y1, int x2, int y2)
{

    //Math.Sqrt(5); //класс математических функций в dotnet, для извлечения корня
    double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    double dRound = Math.Round(d, 2, MidpointRounding.ToZero);//вызываем метод с округлением, первым параметром идет число, которое нужно округлить, вторым параметром до скольки знаков после запятой нужно округлить, третий параметр стратегия округления на подходе к ToZero

    return dRound;

}



