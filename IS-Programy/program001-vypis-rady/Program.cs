// jednořádkový komentář

/*
Toto je 
víceřádkový
komentář
*/

// jako první si připravíme smyčku pro opakování programu

string again = "a";
// .ToLower() - převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Výpis řady******************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Josef Novák*****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");

    // Vstup počáteční hodnoty - špatně řešený
    //Console.Write("Zadejte první číslo řady:");
    //int first = int.Parse(Console.ReadLine());

    // Vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první číslo řady (celé číslo):");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Zadaná hodnota není celé číslo. Zadejte prosím znovu:");
    }

    // Vstup konečné hodnoty - správně řešený
    Console.Write("Zadejte poslední číslo řady (celé číslo):");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("Zadaná hodnota není celé číslo. Zadejte prosím znovu:");
    }

        //vstup diference s kontrolou kladné hodnoty
    Console.Write("Zadejte diferenci (kladné celé číslo): "); 
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné celé číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }

    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";

}