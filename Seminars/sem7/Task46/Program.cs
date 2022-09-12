// Задать двумерный массив MxN 

void FillArray (int[,] collection)
{
    for (int rows = 0; rows < collection.GetLength(0); rows++)
    {
        for (int cols = 0; cols < collection.GetLength(1); cols++)
        {
        collection [rows,cols] = new Random ().Next(0, 10);        
        }
    }
    
}
void PrintArray (int[,] collection1)
{
    for (int rows = 0; rows < collection1.GetLength(0); rows++)
    {
        for (int cols = 0; cols < collection1.GetLength(1); cols++)
        {
        Console.Write ($" {collection1[rows,cols]}");     
        }
        Console.WriteLine ();
    }  
}


Console.WriteLine ("Введите количество строк массива (не менее двух)");
int rowNums = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите количество столбцов массива (не менее двух)");
int colNums = int.Parse (Console.ReadLine());
if (rowNums < 2 || colNums <2) Console.WriteLine ("Неверный ввод");
else
{
    int [,] array = new int [rowNums, colNums];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine ();
}