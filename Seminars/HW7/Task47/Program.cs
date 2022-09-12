// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray (double[,] collection)
{
    int i = 0;
    int j = 0;
    for (i = 0; i < collection.GetLength(0); i++)
    {
        for (j = 0; j < collection.GetLength(1); j++)
        {
            int a = new Random ().Next (-1000000, 1000000);
            int b = new Random ().Next (-10000, 10000);
            collection [i,j] = Math.Round ((float) a / b, 2);        
        }
    }    
}

void PrintArray (double[,] collection1)
{
    int i = 0;
    int j = 0;
        for (i = 0; i < collection1.GetLength(0); i++)
        {
            for (j = 0; j < collection1.GetLength(1); j++)
            {
            Console.Write ($"{collection1[i,j]}\t");     
            }
            Console.WriteLine ();
        }    
}

Console.WriteLine("Enter number or rows");
int rowsNumber = int.Parse (Console.ReadLine());
Console.WriteLine("Enter number or columns");
int columnsNumber = int.Parse (Console.ReadLine());
double [,] array = new double [rowsNumber, columnsNumber];
FillArray(array);
PrintArray (array);
