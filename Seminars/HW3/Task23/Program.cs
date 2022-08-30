// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите целое положительное число");
int Num = int.Parse(Console.ReadLine());
if (Num < 1) Console.WriteLine("Вы ввели неверное число");
else
for (int i=1; i<=Num; i++)
{
    Console.Write($"{Math.Pow (i, 3)} ");
}

