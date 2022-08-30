// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int AinPowerB (int num, int pow)
{
    int numInPower = num;
            for (int count=2; count <= pow; count++)
    {
        numInPower = numInPower * num;
    }
    return numInPower;
}

Console.WriteLine ("Введите первое натуральное число");
int Num = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе натуральное число");
int Power = int.Parse (Console.ReadLine());
if (Num >0 && Power >0)
{
    Console.WriteLine ($"{Num} в степени {Power} равняется {AinPowerB (Num, Power)}");
}
else Console.WriteLine ("Неверный ввод чисел");