// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray (int[,] collection)
{
    int rows = 0;
    int cols = 0;
    for (rows = 0; rows < collection.GetLength(0); rows++)
    {
        for (cols = 0; cols < collection.GetLength(1); cols++)
        {
            collection [rows,cols] = new Random ().Next(0, 10);        
        }
    }   
}

void PrintArray (int[,] collection1)
{
    int rows = 0;
    int cols = 0;
    for (rows = 0; rows < collection1.GetLength(0); rows++)
    {
        for (cols = 0; cols < collection1.GetLength(1); cols++)
        {
            Console.Write ($" {collection1[rows,cols]}");     
        }
        Console.WriteLine ();
    }    
}

void ArrayColumnsAverage (int[,] collection2)
{
    int rows = 0;
    int cols = 0;
    for (cols = 0; cols < collection2.GetLength(1); cols++)
    {
        double average = 0.00;
        int summ = 0;
        for (rows = 0; rows < collection2.GetLength(0); rows++)
        {
            average = average + System.Convert.ToDouble(collection2[rows,cols])/collection2.GetLength(0);    
        }
        Console.WriteLine ($"Среднее элементов столбца № {cols+1} равняется {Math.Round ((float) average, 2)}");
    }   
}

int [,] array = new int [new Random ().Next (2, 6), new Random ().Next (2, 6)];
FillArray(array);
PrintArray(array);
ArrayColumnsAverage (array);
