// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] collection)
{
    int gl0 = collection.GetLength(0), gl1 = collection.GetLength(1);
    for (int rows = 0; rows < gl0; rows++)
    {
        for (int cols = 0; cols < gl1; cols++)
        {
            collection[rows, cols] = new Random().Next(0, 10);
        }
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

int[,] ArraysMultiplication(int[,] collection2, int[,] collection3)
{
    int gl20 = collection2.GetLength(0), gl02 = collection2.GetLength(1);
    int gl30 = collection3.GetLength(0), gl03 = collection3.GetLength(1);
    int[,] arraysMultiply = new int[gl20, gl03];
    for (int i = 0; i < gl20; i++)
    {
        for (int j = 0; j < gl03; j++)
        {
            for (int k = 0; k < gl02; k++)
                arraysMultiply[i, j] = arraysMultiply[i, j] + collection2[i, k] * collection3[k, j];
        }
    }
    return (arraysMultiply);
}

int[,] array1 = new int[new Random().Next(1, 6), new Random().Next(1, 6)];
int[,] array2 = new int[array1.GetLength(1), new Random().Next(1, 6)];

FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение массивов:");
Console.WriteLine();
PrintArray(ArraysMultiplication(array1, array2));
