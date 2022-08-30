// Методы

// Вид 1 (Не принимают )
void Method1 ()
{
    Console.WriteLine ("Такой вот метод");
}
// Вызов такого метода:
Method1();

// Вид 1 (Не возвращают, но принимают)
void Method2 (string msg)
{
    Console.WriteLine (msg);
}
Method2 ("Вот так работает 2 вид методов");

// Вид 3 (не принимает, но возвращает)

int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3 ();
Console.WriteLine (year);

// Вид 4 (принимают и возвращают)

string Method4 (int count, string text)
{
    int i=1;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4 (10, "bla-");
Console.WriteLine (res);