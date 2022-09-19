// See https://aka.ms/new-console-template for more information
// 63
void NumbersRec(int n, int current = 1)
{
    Console.Write(current);
    if (current < n)
    {
        Console.Write(", ");
        NumbersRec(n, ++current);
    }
}

Console.Write("Введите число n: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersRec(number);

// 63 строкой

void NumbersRec(int m, int n)
{
    Console.Write(m);
    if (m < n)
    {
        Console.Write(", ");
        NumbersRec(++m, n);
    }
}
void ShowNumbers(int start, int end, string linetoPrint)
{
    if (start == end)
    {
        linetoPrint = start.ToString() + linetoPrint;
        Console.Write($"{linetoPrint}");
    }
    else
    {
        linetoPrint = ", " + end.ToString() + linetoPrint;
        ShowNumbers(start, end - 1, linetoPrint);
    }
}

перевернуть строку: string ReverseString(string s)
    {
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
    }


//65 
void NumbersRec(int m, int n)
{
    Console.Write(m);
    if (m < n)
    {
        Console.Write(", ");
        NumbersRec(++m, n);
    }
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NumbersRec(numberM, numberN);

//67

int SumRec(int n, int result = 0)
{
    if (n != 0)
    {
        result += n % 10 + SumRec(n / 10, result);
    }
    return result;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumRec(num);
Console.WriteLine(sum);


// 69

int PowNumber(int a, int b)
{
    if (b != 1) a *= PowNumber(a, --b);
    return a;
}


Console.Write("Введите число a: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB == 0) Console.WriteLine(1);
else if ((numB == 1) || (numA == 1 || numA == 0)) Console.WriteLine(numA);
else Console.WriteLine(PowNumber(numA, numB));