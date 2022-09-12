// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.

void ArabicIntoRoman (int num, string [,] table)
{
    string addFigures = "";
    for (int i = 0; i != 4; i++)
    {
        addFigures = table[i, num%10] + addFigures;
        // Console.Write($"{table[i, num%10]}");
        num = num/10;
    }
    Console.WriteLine($"{addFigures}");
}

string[,] romanNums = new string [,] 
{
    {"","I","II","III","IV","V","VI","VII","VIII","IX"}, 
    {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"}, 
    {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"}, 
    {"","M","MM","MMM","","","","","",""}
};

Console.WriteLine ("Введите число 1 to 3999");
int arabicEntered = int.Parse (Console.ReadLine());
if (arabicEntered <1 || arabicEntered > 3999)
{
    Console.WriteLine ("Вы ввели неверное число");    
}
else ArabicIntoRoman (arabicEntered, romanNums);


