string again = "a";
// .ToLower() - převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Název prgramu******************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Josef Novák*****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");

    // Vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první hodnotu (celé číslo):");
    int aaa;
    while (!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.WriteLine("Zadaná hodnota není celé číslo. Zadejte prosím znovu:");
    }

    // Vstup konečné hodnoty - správně řešený
    Console.Write("Zadejte poslední hodnotu (celé číslo):");
    int bbb;
    while (!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.WriteLine("Zadaná hodnota není celé číslo. Zadejte prosím znovu:");
    }


    // Výpis zadaných hodnot v jedné řádce
    Console.WriteLine("===========================");
    Console.WriteLine($"První hodnota: {aaa}, poslední hodnota: {bbb}");
    Console.WriteLine("===========================");

    // Jádro algoritmu - výpis řady
    
    // Konec jádra algoritmu - výpis řady
    

    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";

}