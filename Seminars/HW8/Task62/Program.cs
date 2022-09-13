// Задача 62. Напишите программу, которая заполнит массив 4х4 спиралью последовательных чисел (с элемента 0,0 по часовой)

void FillArrayClockSnake(int[,] collection)
{
    int gl0 = collection.GetLength(0), gl1 = collection.GetLength(1);
    int count = 1;
    for (int i = 0; i < gl1; i++)
    {
        collection[0, i] = count;
        count++;
    }
    for (int j = 1; j < gl0; j++)
    {
        collection[j, gl1 - 1] = count;
        count++;
    }
    for (int k = gl1 - 2; k > 0; k--)
    {
        collection[gl0 - 1, k] = count;
        count++;
    }
    for (int m = gl0 - 1; m > 0; m--)
    {
        collection[m, 0] = count;
        count++;
    }
    int a = 1, b = 1;
    while (collection[a, b] == 0)
    {
        collection[a, b] = count;
        b++;
        count++;
    }
    while (collection[a + 1, b] == 0)
    {
        collection[a + 1, b] = count;
        a++;
        count++;
    }
    while (collection[a + 1, b - 1] == 0)
    {
        collection[a + 1, b - 1] = count;
        b--;
        count++;
    }
}

void PrintArray(int[,] collection1)
{
    int gl0 = collection1.GetLength(0), gl1 = collection1.GetLength(1);
    for (int rows = 0; rows < gl0; rows++)
    {
        for (int cols = 0; cols < gl1; cols++)
        {
            Console.Write($"{collection1[rows, cols]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
PrintArray(array);
Console.WriteLine();
FillArrayClockSnake(array);
PrintArray(array);