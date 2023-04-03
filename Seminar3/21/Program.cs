// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату X первой точки: ");
double x1 = double.Parse(Console.ReadLine()!);


Console.WriteLine("Введите координату Y первой точки: ");
double y1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z первой точки: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X второй точки: ");
double x2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y второй точки: ");
double y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z второй точки: ");
double z2 = double.Parse(Console.ReadLine()!);

double s = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z1,2));
Console.WriteLine($"{s:f3}");