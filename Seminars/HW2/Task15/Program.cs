// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine ("Введите номер дня недели");
int DayNum = int.Parse (Console.ReadLine ());
if (DayNum < 1 || DayNum > 7) Console.WriteLine ("Дня недели с таким номером не существует");
else if (DayNum == 6 || DayNum == 7) Console.WriteLine ("Введенный Вами день является выходным");
else Console.WriteLine ("Введенный Вами день не является выходным");
