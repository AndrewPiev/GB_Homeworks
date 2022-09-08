// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CrossLinesPoint (int k1, int b1, int k2, int b2)
{
    if (k1 == k2) Console.WriteLine ("Заданные прямые не пересекаются");
    else
    {
        double x = (float) (b2-b1)/(k1-k2);
        double y = (float) k1*(b2-b1)/(k1-k2)+b1;
        Console.WriteLine ($"Заданные прямые пересекаются в точке x={x}, y={y}");
    }
}

Console.WriteLine ("Мы будем искать точку пересечения прямых y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine ("Задайте коэффициент k1");
int a = int.Parse (Console.ReadLine());
Console.WriteLine ("Задайте постоянную b1");
int b = int.Parse (Console.ReadLine());
Console.WriteLine ("Задайте коэффициент k2");
int c = int.Parse (Console.ReadLine());
Console.WriteLine ("Задайте постоянную b2");
int d = int.Parse (Console.ReadLine());

CrossLinesPoint (a, b, c, d);

