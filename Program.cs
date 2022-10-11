// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите Х координаты точки A: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки A: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки A: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Х координаты точки B: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки B: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки B: ");
int z2 = int.Parse(Console.ReadLine()!);
double result;
result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.Write($"Длина отрезка АВ равна : {result:f2}");
