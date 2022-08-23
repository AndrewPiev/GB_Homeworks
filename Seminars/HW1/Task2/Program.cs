// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое целое число:");
int FirstNum = int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int SecondNum = int.Parse (Console.ReadLine());

if (SecondNum > FirstNum)
{
    Console.WriteLine($"Максимальное из двух введенных чисел равно: {SecondNum}");
    Console.WriteLine($"Минимальное из двух введенных чисел равно: {FirstNum}");
}
else
{
    if (SecondNum == FirstNum)
    Console.WriteLine("Введенные числа равны");
else
{
    Console.WriteLine($"Максимальное из двух введенных чисел равно: {FirstNum}");
    Console.WriteLine($"Минимальное из двух введенных чисел равно: {SecondNum}");
}
}
