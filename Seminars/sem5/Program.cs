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

void Find (int [] ar, int find)
{
    for (int i=1; i<ar.Length;)
    {
        ar [i] = find;
        Console.WriteLine ("Искомое число найдено");
        break;
    }
    Console.WriteLine ("Искомое число не найдено");
}


Console.WriteLine ("Введите натуральное число для определения размерности массива");
int Num = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите верхний предел для значений массива");
int Max = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите минимальное значение для элементов массива");
int Min = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите число, которое неоходимо обнаружить в массиве");
int FindNum = int.Parse (Console.ReadLine());

int [] array = new int [Num];
FillArray (array, Min, Max);
PrintArray (array);
Find (array, FindNum);

