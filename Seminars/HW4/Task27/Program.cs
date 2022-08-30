// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
double SumNumbers (int num)
{
        double Sum = num%10;
        int count=1;

    if (num/10>=1)
    {
        while (num/Math.Pow (10, count)>0)
        {
            count++;
            Sum = Sum + ((num%Math.Pow (10, count) - (num%Math.Pow (10, count-1)))/(Math.Pow (10, count-1)));          
        }
       
    }
 return Sum;      
}
Console.WriteLine ("Введите целое число");
int Num = int.Parse (Console.ReadLine());
Console.WriteLine ($"Сумма цифр введенного числа равна {SumNumbers(Num)}");
