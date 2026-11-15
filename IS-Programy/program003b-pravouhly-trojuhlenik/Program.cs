string again = "a";
// .ToLower() - převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***********Vykreslení obdelníku********");
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Josef Novák*****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");

    

    // Vstup pro výšku
    Console.Write("Zadejte výšku trojuhelníku (kladné celé číslo):");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Zadaná hodnota není kladné celé číslo. Zadejte prosím znovu:");
        Console.ResetColor();
    }


    // Výpis zadaných hodnot v jedné řádce
    Console.WriteLine("===========================");
    Console.WriteLine($"Výška: {height}");
    Console.WriteLine("===========================");

    // Jádro algoritmu 
    
    // Vnější cyklus, který bude řídit správný počet zobrazených řádků (výška)
    for (int i = 1; i <= height; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }


        // Vnitřní cyklus, který bude řídit správný počet zobrazených hvězdiček (šířka)
        for(int j = 1; j < i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(200));
        }
        Console.WriteLine("* ");
        Console.ResetColor();

    }
    // Konec jádra algoritmu 


    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";

}