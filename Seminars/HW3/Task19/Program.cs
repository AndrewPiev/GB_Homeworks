// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число:");
int Num = int.Parse(Console.ReadLine());
if (Math.Abs (Num) < 10000 || Math.Abs (Num) > 99999) Console.WriteLine ("Вы ввели неверное число");
else
{
if (Math.Abs (Num)%10 == Math.Abs (Num) / 10000 & (Num)/1000-Math.Abs (Num)/10000*10 == (Math.Abs (Num)%100)/10)
{
Console.WriteLine($"Введенное число является палиндромом");
}
else Console.WriteLine($"Введенное число не является палиндромом");
}

// Console.WriteLine (Math.Abs (Num)%10);
// Console.WriteLine (Math.Abs (Num) / 10000);
// Console.WriteLine ((Num)/1000-Math.Abs (Num)/10000*10);
// Console.WriteLine ((Math.Abs (Num)%100)/10);