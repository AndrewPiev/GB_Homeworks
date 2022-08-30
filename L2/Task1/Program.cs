int Max (int a1, int a2)
{
  int result  = a1;
  if (a2 > result) result = a2;
  return result;
}
Console.WriteLine (Max (10, 2));