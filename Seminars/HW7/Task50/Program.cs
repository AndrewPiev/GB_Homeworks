// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.

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

void FindNumberReturnPosition (int[,] collection2, int num)
{
    int rows = 0;
    int cols = 0;
    int count = 0;
    for (rows = 0; rows < collection2.GetLength(0); rows++)
        {
            for (cols = 0; cols < collection2.GetLength(1); cols++)
            {
            if (collection2[rows,cols] == num) 
            {
                Console.WriteLine ($"Искомое число найдено на позиции массива [{rows}, {cols}]");
                count++;
            }    
            }            
        }
    if (count == 0) Console.WriteLine ($"Искомое число в массиве не найдено");
    else Console.WriteLine ($"Всего найдено {count} совпадений");
}

Console.WriteLine("Введите число от 0 до 9, которое будем искать в случайном массиве");
int number = int.Parse (Console.ReadLine());
int [,] array = new int [new Random ().Next (2, 6), new Random ().Next (2, 6)];
FillArray(array);
PrintArray(array);
FindNumberReturnPosition(array, number);