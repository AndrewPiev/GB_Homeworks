// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine ("Введите координату X первой точки");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату Y первой точки");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату Z первой точки");
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату X второй точки");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату Y второй точки");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату Z второй точки");
double Z2 = double.Parse(Console.ReadLine());
Console.WriteLine ($"Длина введенного отрезка составлет {Math.Sqrt(Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2) + Math.Pow((Z2-Z1), 2))} координатных единиц");
