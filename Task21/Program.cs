// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21. Введите координаты двух точек");

Console.Write("Координата X Точки A: ");
int XA = int.Parse(Console.ReadLine());
Console.Write("Координата Y Точки A: ");
int YA = int.Parse(Console.ReadLine());
Console.Write("Координата Z Точки A: ");
int ZA = int.Parse(Console.ReadLine());

Console.Write("Координата X Точки B: ");
int XB = int.Parse(Console.ReadLine());
Console.Write("Координата Y Точки B: ");
int YB = int.Parse(Console.ReadLine());
Console.Write("Координата Z Точки B: ");
int ZB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(XB - XA, 2) + Math.Pow(YB - YA, 2) + Math.Pow(ZB - ZA, 2));
Console.WriteLine($"\nA({XA}, {YA}, {ZA}); B({XB}, {YB}, {ZB}) -> {distance}");
