// Задача 49 сгенерировать массив и для элементов с обоими четными индексами произвети замену на квадрат имеющегося значения

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
        Console.Write ($"  {collection1[rows,cols]}   ");     
        }
        Console.WriteLine ();
    }   
}


void ArrayEvenInPower (int[,] collection2)
{
    int rows = 0;
    int cols = 0;
    for (rows = 0; rows < collection2.GetLength(0); rows++)
    {
        for (cols = 0; cols < collection2.GetLength(1); cols++)
        {
            if (rows%2 == 0 && cols%2 == 0)
            {
                collection2[rows,cols] = collection2[rows,cols]*collection2[rows,cols];
            }   
        }
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
    FillArray (array);
    PrintArray (array);
    Console.WriteLine ();
    ArrayEvenInPower (array);
    PrintArray (array);
}