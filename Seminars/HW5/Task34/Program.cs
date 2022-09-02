// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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

int EvenNumsInArrayCounter (int[] ar)
{
    int count =0;
    for (int i = 0; i < ar.Length; i++)
    {
        // int div2remains = col[i]%2;
        if (ar[i]%2 == 0) 
        {
            count = count + 1;
        }
    }
    return count;
}
Console.WriteLine ("Введите натуральное число для определения размерности массива");
int Num = int.Parse (Console.ReadLine());
int [] array = new int [Num];
FillArray (array, 100, 1000);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine ($"Количество четных элементов массива равняется {EvenNumsInArrayCounter(array)}");
