// int[] ReverseArray(int[] array) 
// {
//     int size = array.Length;
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = array[size - 1 - i];
//     }
//     return result;
// }

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return res;
// }

// void ReverseArray2(int[] array) 
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// int[] myArray = GetArray(10, 0, 10);
// Console.Write(String.Join(" ", myArray));
// Console.WriteLine();
// Console.Write(String.Join(" ", ReverseArray(myArray)));
// Console.WriteLine();
// ReverseArray2(myArray);
// Console.Write(String.Join(" ", myArray));

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string Binary(int num)
// {
//     string binaryNum = String.Empty;
//     while (num > 0)
//     {
//         if (num % 2 == 1) binaryNum += "1";
//         else binaryNum += "0";
//         num /= 2;
//     }
//     return binaryNum;
// }

// string ReverseBinary(string stringNum)
// {
//     string temp = String.Empty;
//     for (int i = stringNum.Length - 1; i >= 0; i--)
//     {
//         temp += stringNum[i];
//     }
//     return temp;
// }

// Console.Write("Введите число: ");
// int decNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ReverseBinary(Binary(decNum)));




// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void PrintArray (int [] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write ($"{col[position]} ");
//         position++;
//     }
// }

// int PosInArray (int [] col)
// {
//     int PosCounter = 0;
//     int position = 0;
//     while (position < col.Length)
//     {
//         if (col[position] > 0) PosCounter++;
//         position++;
//     }
//     return PosCounter;
// }

// Console.WriteLine ("Сколько чисел необходимо ввести?");
// int Size = int.Parse (Console.ReadLine());
// int [] array = new int [Size];
// int count = 0;
// int i = 0;
// for (i=0; i < Size; i++)
// {
//     Console.WriteLine ($"Введите число № {i+1}");
//     int Num = int.Parse (Console.ReadLine());
//     array [i] = Num;
//     if (Num >0) count+=1;
// }

// Console.WriteLine ($"Вы ввели {count} положительных числа (-ел)");
// Console.Write ($"Или другими словами в массиве ");
// PrintArray (array);
// Console.Write ($"количество положительных чисел составляет {PosInArray (array)}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void CrossLinesPoint (int k1, int b1, int k2, int b2)
// {
//     if (k1 == k2) Console.WriteLine ("Заданные прямые не пересекаются");
//     else
//     {
//         double x = (float) (b2-b1)/(k1-k2);
//         double y = (float) k1*(b2-b1)/(k1-k2)+b1;
//         Console.WriteLine ($"Заданные прямые пересекаются в точке x={x}, y={y}");
//     }
// }

// Console.WriteLine ("Мы будем искать точку пересечения прямых y = k1 * x + b1, y = k2 * x + b2");

// Console.WriteLine ("Введите коэффициент k1");
// int a = int.Parse (Console.ReadLine());
// Console.WriteLine ("Введите b1");
// int b = int.Parse (Console.ReadLine());
// Console.WriteLine ("Введите коэффициент k2");
// int c = int.Parse (Console.ReadLine());
// Console.WriteLine ("Введите b2");
// int d = int.Parse (Console.ReadLine());

// CrossLinesPoint (a, b, c, d);




