// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое целое число:");
int FirstNum = int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int SecondNum = int.Parse (Console.ReadLine());

Console.WriteLine("Введите третье целое число:");
int ThirddNum = int.Parse (Console.ReadLine());

int Max = FirstNum;
 
 if (SecondNum > FirstNum)
 {
     Max = SecondNum;
 }
 if (SecondNum < ThirddNum)
 {
     Max = ThirddNum;
 }
Console.WriteLine($"Максимальное из трех введенных чисел равно: {Max}");
