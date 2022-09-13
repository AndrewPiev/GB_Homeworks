// See Задача 54: Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray (int[,] collection)
{
    int gl0 = collection.GetLength(0), gl1 = collection.GetLength(1);
    for (int rows = 0; rows < gl0; rows++)
    {
        for (int cols = 0; cols < gl1; cols++)
        {
        collection [rows,cols] = new Random ().Next(0, 10);        
        }
    }   
}

void PrintArray (int[,] collection1)
{
    int gl0 = collection1.GetLength(0), gl1 = collection1.GetLength(1);
    for (int rows = 0; rows < gl0; rows++)
    {
        for (int cols = 0; cols < gl1; cols++)
        {
        Console.Write ($" {collection1[rows,cols]}");     
        }
        Console.WriteLine ();
    }    
}

void BubbleRowsDecrease (int[,] collection2)
{
    int gl0 = collection2.GetLength(0), gl1 = collection2.GetLength(1);
    for (int i = 0; i < gl0; i++)
    {
        for (int j = 0; j < gl1; j++)
        {
            for (int k = 1; k < gl1-j; k++)
            {
                if (collection2 [i, k] > collection2 [i, k-1])
                {
                    int Sort = collection2 [i, k];
                    collection2 [i, k] = collection2 [i, k-1];
                    collection2 [i, k-1] = Sort;
                }
            }
        }
    }
}

int [,] array = new int [new Random ().Next (2, 11), new Random ().Next (5, 11)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
BubbleRowsDecrease (array);
PrintArray (array);
