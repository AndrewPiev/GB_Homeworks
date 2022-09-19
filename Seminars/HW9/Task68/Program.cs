// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
 {
    if (m == 0)
    {
        return n + 1;
    }
    else if((m > 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else if((m > 0) && (n > 0))
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else return n + 1;
}


Console.WriteLine("Вычисляем функцию Аккермана для чисел m и n");
Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write (Akkerman(numberM, numberN));
