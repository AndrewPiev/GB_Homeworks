// See Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите положительное трехзначное число:");
int Num = int.Parse(Console.ReadLine());
if (Math.Abs (Num) < 100 || Math.Abs (Num) > 999) Console.WriteLine ("Вы ввели неверное число");
else 
{
    int SecondNumber = Math.Abs (Num)/10 - Math.Abs (Num)/100*10;
Console.WriteLine($"Вторая цифра из введенного числа равна: {SecondNumber}");
}
