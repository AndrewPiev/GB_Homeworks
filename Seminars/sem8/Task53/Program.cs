// Создать массив и поменять первую и последнюю строки местами
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
void ChangeRows (int [,] collection2)
{
    int cols = 0;
    for (cols = 0; cols < collection2.GetLength(1); cols++)
    {
        int temp = collection2[0, cols];
        collection2[0,cols] = collection2[collection2.GetLength(0)-1, cols];
        collection2[collection2.GetLength(0)-1, cols] = temp;
    }
        for (int i = 0; i < collection2.GetLength(0); i++)
    {
        for (int j = 0; j < collection2.GetLength(1); j++)
        {
        Console.Write ($" {collection2[i,j]}");     
        }
        Console.WriteLine ();
    } 
}


int [,] array = new int [new Random ().Next (2, 6), new Random ().Next (2, 6)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRows(array);