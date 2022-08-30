// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void FirPainting (int FirH)
{
    int FirTrunk = FirH/5;
    Console.SetCursorPosition (40,0);
    Console.WriteLine ("+");
        for (int Count2 = 1; Count2 <= FirH-FirTrunk; Count2++)
        {
            Console.SetCursorPosition(40-Count2, Count2);
            Console.Write ("+ ");
        }
         for (int Count3 = 1; Count3 <= FirH-FirTrunk; Count3++)
        {
            Console.SetCursorPosition(40+Count3, Count3);
            Console.Write ("+ ");
        }
        
        Console.SetCursorPosition(40-(FirH-FirTrunk), FirH-FirTrunk);
        for (int Count5 = FirH-FirTrunk; Count5 <= FirH; Count5++)
        {
                Console.Write (" + ");
        }

        Console.SetCursorPosition(40, FirH-FirTrunk);
        for (int Count6 = FirH-FirTrunk; Count6 <= FirH; Count6++)
        {
                Console.Write (" + ");
        }
        
        for (int Count4 = FirH-FirTrunk; Count4 <= FirH; Count4++)
        {
            Console.SetCursorPosition(40, Count4);
            Console.Write ("++");
        }
        Console.WriteLine ();

}

Console.WriteLine ("Введите высоту елочки");
int FirHeight = int.Parse (Console.ReadLine());
Console.Clear();
FirPainting (FirHeight);

