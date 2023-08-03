// Задача 20:
// Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,  6); B (2,  1) –> 5,09
// A (7, -5); B (1, -1) –> 7,21

// double d = 5,0990195135927845;
// int n = (int)d; // Явное преобразование типа double в тип int.
// Math.Pow(23, 2); // Возведение в степень.

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        // Извлечение корня (неявное преобразование типа int в тип double).
}

Console.WriteLine("Введите координаты первой точки.");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки.");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
    // Округление до 2 знаков после запятой. MidpointRounding.ToZero - стратегия округления.
Console.WriteLine($"Расстояние между точками в 2D пространстве: {distanceRound}");
