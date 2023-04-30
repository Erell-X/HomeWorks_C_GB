// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1, x2, y1, y2, z1, z2;
double distance;

Console.Clear();

Console.Write("Введите координату x1: ");
x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1: ");
z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите координату x2: ");
x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2: ");
z2 = Convert.ToInt32(Console.ReadLine());

distance = (x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1);
distance = Math.Sqrt(distance);
distance = Math.Round(distance, 2);

Console.WriteLine($"Расстояние между 2-мя точками равно: {distance}");
Console.WriteLine();