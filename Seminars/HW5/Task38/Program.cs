// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index <length)
    {
        int a = new Random ().Next (1, 1000000);
        int b = new Random ().Next (1, 10000);
        collection [index] = Math.Round ((float) a / b, 2);
        index++;
    }
}

void PrintArray (double [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{col[position]} ");
        position++;
    }
}


double FindMax (double [] arr)
{
    double ArMax = arr [0];
    for (int count=1; count < arr.Length; count++)
    {
        if (arr[count] > ArMax) ArMax = arr[count];
    }
    return ArMax;
}

double FindMin (double [] ar)
{
    double ArMin = ar [0];
    for (int count=1; count < ar.Length; count++)
    {
        if (ar[count] < ArMin) ArMin = ar[count];
    }
    return ArMin;
}

Console.WriteLine ("Введите натуральное число для определения размерности массива");
int Num = int.Parse (Console.ReadLine());

double [] array = new double [Num];
FillArray (array);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine ($"Минимальное и максимальное массива равны {FindMin(array)} и {FindMax(array)}, а их разница составляет {Math.Round((float) FindMax(array) - FindMin(array), 2)}");

