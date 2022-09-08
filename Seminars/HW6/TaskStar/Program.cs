// Задача со звездочкой: Печать элементов обхода границ двумерного массива начиная с нижнего левого элемента



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

void PrintArrayBorderNums (int[,] collection2)
{
    for (int lowerBorder = 0; lowerBorder < collection2.GetLength(1); lowerBorder++) // lower border of array
    {
        Console.Write ($" {collection2[collection2.GetLength(0)-1,lowerBorder]}");
    }
    
    for (int rihgtBorder = collection2.GetLength(0)-2; rihgtBorder > 0; rihgtBorder--) // right border of array
    {
        Console.Write ($" {collection2[rihgtBorder,collection2.GetLength(1)-1]}");
    }

    for (int upperBorder = collection2.GetLength(1) - 1; upperBorder > 0; upperBorder--) // upper border of array
    {
        Console.Write ($" {collection2[0,upperBorder]}");
    }
    for (int leftBorder = 0; leftBorder < collection2.GetLength(0)-1; leftBorder++) // left border of array
    {
        Console.Write ($" {collection2[leftBorder,0]}");
    }

}
Console.WriteLine ("Введите количество строк массива (не менее двух)");
int rowNums = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите количество столбцов массива (не менее двух)");
int colNums = int.Parse (Console.ReadLine());

int [,] array = new int [rowNums, colNums];
Console.WriteLine ();
if (rowNums < 2 || colNums <2) Console.WriteLine ("Неверный ввод");
else
{
    FillArray (array);
    PrintArray (array);
    Console.WriteLine ();
    PrintArrayBorderNums (array);
}
