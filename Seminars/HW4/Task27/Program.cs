// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// double SumNumbers (int num)
// {
//         double Sum = num%10;
//         int count=1;

//     if (num/10>=1)
//     {
//         while (num/Math.Pow (10, count)>0)
//         {
//             count++;
//             Sum = Sum + ((num%Math.Pow (10, count) - (num%Math.Pow (10, count-1)))/(Math.Pow (10, count-1)));          
//         }
       
//     }
//  return Sum;      
// }
int SumNumbers2 (int num1)
{
    int sum = num1%10;
    while (num1/10!=0)
    {
        num1 = num1 / 10;
        sum = sum + num1%10;
    }
    return sum;
}
Console.WriteLine ("Введите целое число");
int Num = int.Parse (Console.ReadLine());
Console.WriteLine ($"Сумма цифр введенного числа равна {SumNumbers2(Num)}");
