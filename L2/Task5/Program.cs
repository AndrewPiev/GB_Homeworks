// Работа со строками
string Pushkin = "«Мой дядя самых честных правил, Когда не в шутку занемог, Он уважать себя заставил И лучше выдумать не мог.";
string Replace (string text, char oldChar, char newChar)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldChar) result = result + $"{newChar}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace (Pushkin, ' ', '|');
Console.WriteLine (NewText);
