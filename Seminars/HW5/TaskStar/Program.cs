// Задача со звездочкой: Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index <length)
    {
        collection [index] = new Random ().Next(1, 10);
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
int[] Bubble (int[] arr)
{
    for (int count = 0; count < arr.Length; count++)
    {
        int Sort = 0;
        int count2 = 0;
        for (count2 = 1; count2 < arr.Length-count; count2++)
        if (arr[count2-1] < arr [count2])
        {
            Sort = arr [count2-1];
            arr[count2-1] = arr[count2];
            arr[count2] = Sort;
        }
        
    }
    return arr;
}


Console.WriteLine ("Введите натуральное число для определения размерности массива");
int Num = int.Parse (Console.ReadLine());

int [] array = new int [Num];
FillArray (array);
PrintArray (array);
Console.WriteLine ();
Bubble (array);
Console.WriteLine ("Отсортированный массив:");
PrintArray (array);
