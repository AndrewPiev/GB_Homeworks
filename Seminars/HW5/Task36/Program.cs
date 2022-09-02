// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] collection, int LowerLimit, int UpperLimit)
{
    int length = collection.Length;
    int index = 0;
    while (index <length)
    {
        collection [index] = new Random ().Next(LowerLimit, UpperLimit);
        index++;
    }
}

void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{col[position]} ");
        position++;
    }
}

void EvPosSum (int[] ar)
{
    int sumEvPos = 0;
    for (int count=0; count < ar.Length; count++)
    {
        if (count % 2 > 0)
        {
            sumEvPos+=ar[count];   
        }
    }
    Console.WriteLine ($"Сумма нечтных элементов массива равна {sumEvPos}");
    
}

Console.WriteLine ("Введите натуральное число для определения размерности массива");
int Num = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите верхний предел для значений массива");
int Max = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите минимальное значение для элементов массива");
int Min = int.Parse (Console.ReadLine());


int [] array = new int [Num];
FillArray (array, Min, Max);
PrintArray (array);
Console.WriteLine ();
EvPosSum (array);