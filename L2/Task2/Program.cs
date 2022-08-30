// Заполнение и печать массива

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

int [] array = new int [10];
FillArray (array);
int sum = 0;
int find = 5;
for (int i = 0; i < array.Length; i++)
{
   Console.Write ($" {array[i]}");
}
Console.WriteLine ();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == find)
    {
        Console.WriteLine ($"Индекс искомого значения {find} равен: {i}");
        break;
    } 
}
Console.WriteLine ("Запус метода печати массива:");
PrintArray (array);
