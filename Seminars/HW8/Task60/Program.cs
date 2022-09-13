// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Fill3DArrayWithoutRepeat(int[,,] collection)
{
    int gl = collection.GetLength(0);
    int forStep = 50/gl;
    for (int i = 0; i < gl; i++)
    {
        for (int j = 0; j < gl; j++)
        {
            for (int k = 0; k < gl; k++)
            {
                collection[i, j, k] = forStep;
                forStep++;
            }
            forStep++;
        }
    }
}
void Print3DArray(int[,,] collection1)
{
    int gl = collection1.GetLength(0);
    for (int i = 0; i < gl; i++)
    {
        for (int j = 0; j < gl; j++)
        {
            for (int k = 0; k < gl; k++)
            {
                Console.Write ($"{collection1[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите размер кубического массива от 2 до 4");
int arrayDimension = int.Parse(Console.ReadLine());

int[,,] array = new int[arrayDimension, arrayDimension, arrayDimension];
Fill3DArrayWithoutRepeat(array);
Print3DArray(array);
Console.WriteLine();

