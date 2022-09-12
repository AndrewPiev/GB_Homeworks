// Задача со звездочкой: Из римских в арабские

void RomanIntoArabic (string a)
{
    char [] b = new char [a.Length];

    for (int i=0; i<a.Length; i++)
    {
        b[i] = a[i];
    }

    int [] c = new int [a.Length];

    for (int i = 0; i < a.Length; i++)
    {
        if (b[i] == 'M') c[i] = 1000;
        if (b[i] == 'D') c[i] = 500;
        if (b[i] == 'C') c[i] = 100;
        if (b[i] == 'L') c[i] = 50;
        if (b[i] == 'X') c[i] = 10;
        if (b[i] == 'V') c[i] = 5;
        if (b[i] == 'I') c[i] = 1;
    }

    int summ = 0;
    for (int j = 0; j < a.Length-1; j++)
    {
        if (c[j] >= c [j+1]) summ = summ + c[j];
        else summ = summ - c [j];
    }

    Console.WriteLine ($"{summ+c[a.Length-1]}");
}

Console.WriteLine ("Ведите римское число");
string roman = (Console.ReadLine());

RomanIntoArabic (roman);