// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{col[position]} ");
        position++;
    }
}

int PositiveInArrayCounter (int [] col)
{
    int PosCounter = 0;
    int position = 0;
    while (position < col.Length)
    {
        if (col[position] > 0) PosCounter++;
        position++;
    }
    return PosCounter;
}

Console.WriteLine ("Сколько чисел необходимо ввести?");
int Size = int.Parse (Console.ReadLine());
int [] array = new int [Size];
int count = 0;
int i = 0;
for (i=0; i < Size; i++)
{
    Console.WriteLine ($"Введите число № {i+1}");
    int Num = int.Parse (Console.ReadLine());
    array [i] = Num;
    if (Num >0) count+=1;
}

Console.WriteLine ($"Вы ввели {count} положительных числа (-ел)");
Console.Write ("Или другими словами в массиве { ");
PrintArray (array);
Console.Write ("}");
Console.Write ($" количество положительных чисел составляет {PositiveInArrayCounter (array)}");
