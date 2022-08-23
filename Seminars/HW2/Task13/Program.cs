// See Задача 13: Напишите программу, которая выводит третью цифру справа заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число для определения его третьей цифры:");
int Num = int.Parse(Console.ReadLine());
if (Math.Abs (Num) < 100) Console.WriteLine ("У введенного числа нет третьей цифры");
else
{
    int ThirdNum = (Math.Abs(Num) / 100) % 10;
    Console.WriteLine($"Третья цифра из введенного числа равна: {ThirdNum}");
}
