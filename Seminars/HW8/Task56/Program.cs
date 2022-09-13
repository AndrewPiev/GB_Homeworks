// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindRowMinElementsSum(int[,] collection2)
{
    int gl0 = collection2.GetLength(0), gl1 = collection2.GetLength(1);
    int[] summs = new int[gl0];
    for (int rows = 0; rows < gl0; rows++)
    {
        int summ = 0;
        for (int cols = 0; cols < gl1; cols++)
        {
            summs[rows] = summs[rows] + collection2[rows, cols];
        }
    }
    int min = summs[0];
    int minPosition = 0;
    for (int i = 1; i < gl0; i++)
    {
        if (summs[i] < min)
        {
            min = summs[i];
            minPosition = i;
        }
    }
    for (int j = 0; j < gl0; j++)
    {
        for (int k = 0; k < gl1; k++)
        {
            Console.Write($" {collection2[j, k]}");
        }
        Console.WriteLine($" - сумма элементов данной строки составляет {summs[j]}");
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов найдена в сроке № {minPosition + 1} и составляет {min}");
}

int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
FillArray(array);
Console.WriteLine();
FindRowMinElementsSum(array);
Console.WriteLine();
