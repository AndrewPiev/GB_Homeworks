// Задача 48 Создать массив из элементов произведения номеров строки и столбца элемента MxN 


void FillArrayMplusN (int[,] collection)
{
    int rows = 0;
    int cols = 0;
    for (rows = 0; rows < collection.GetLength(0); rows++)
    {
        for (cols = 0; cols < collection.GetLength(1); cols++)
        {
        collection [rows,cols] = rows + cols;        
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

Console.WriteLine ("Введите количество строк массива (не менее двух)");
int rowNums = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите количество столбцов массива (не менее двух)");
int colNums = int.Parse (Console.ReadLine());


Console.WriteLine ();
if (rowNums < 2 || colNums <2) Console.WriteLine ("Неверный ввод");
else
{
    int [,] array = new int [rowNums, colNums];
    FillArrayMplusN (array);
    PrintArray (array);   
}

