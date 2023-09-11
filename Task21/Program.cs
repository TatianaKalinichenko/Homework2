// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки:");
Console.WriteLine("X1: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int zCoordinate1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.WriteLine("X2: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2: ");
int zCoordinate2 = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xCoordinate1, yCoordinate1, zCoordinate1, xCoordinate2, yCoordinate2, zCoordinate2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками в пространстве: {distRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2-z1)*(z2-z1));
    
    return distance;
}
