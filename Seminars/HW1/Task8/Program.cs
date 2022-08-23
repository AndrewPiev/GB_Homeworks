// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое положительное число:");
int Num = int.Parse(Console.ReadLine());
if (Num < 0 || Num == 0) Console.WriteLine ("Вы ввели неверное число");
int count = 1;
while (count < Num + 1)
{
    if (count % 2 == 0) Console.Write ($"{count} ");
    count++;
}
