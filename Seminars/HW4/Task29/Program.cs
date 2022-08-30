// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

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

Console.WriteLine ("Введите натуральное число для определения размерности массива");
int Num = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите верхний предел для значений массива");
int Max = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите минимальное значение для элементов массива");
int Min = int.Parse (Console.ReadLine());

int [] array = new int [Num];
FillArray (array, Min, Max);
PrintArray (array);

