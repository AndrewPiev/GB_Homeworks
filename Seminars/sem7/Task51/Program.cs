// Задать двумерный массив и найти сумму элементов расположенных на главной диагонали

void FillArray (int[,] collection)
{
    int rows = 0;
    int cols = 0;
    for (rows = 0; rows < collection.GetLength(0); rows++)
    {
        for (cols = 0; cols < collection.GetLength(1); cols++)
        {
        collection [rows,cols] = new Random ().Next(0, 100000);        
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
        Console.Write ($" {collection1[rows,cols]}\t");     
        }
        Console.WriteLine ();
    }
    
}


void diagonalArrayElementsSumm (int[,] collection2)
{
    int diagonalPosition = 0;
    int Summ = 0; 
    for (diagonalPosition = 0; diagonalPosition < collection2.GetLength(0); diagonalPosition++)
    {
        {
           Summ = Summ + collection2[diagonalPosition, diagonalPosition];
        }   
    }
    Console.WriteLine ($"Сумма диагональных элементов массива равна {Summ}");
}
Console.WriteLine ("Введите размерность массива (не менее двух)");
int size = int.Parse (Console.ReadLine());

Console.WriteLine ();
if (size < 2) Console.WriteLine ("Неверный ввод");
else
{
    int [,] array = new int [size, size];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine ();
    diagonalArrayElementsSumm (array);
    Console.WriteLine ();
}