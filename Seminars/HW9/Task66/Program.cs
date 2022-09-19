// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int IntervalSumm (int m, int n)
{
    if (m == n) return n;
    else return m + IntervalSumm (m+1, n);     
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write (IntervalSumm (numberM, numberN));
