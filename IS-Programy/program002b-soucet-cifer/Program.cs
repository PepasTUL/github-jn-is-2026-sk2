string again = "a";
// .ToLower() - převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a"){



    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Soucet cifer****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Josef Novák*****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");

    // Vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte hodnotu (celé číslo):");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Zadaná hodnota není celé číslo. Zadejte prosím znovu:");
    }
    // Jádro algoritmu - výpis řady


    // 1. Příprava pomocných proměnných pro výpočet
    int numberBackup = number; //záloha původního čísla pro závěrečný výpis
    int sum = 0; //proměnná pro součet cifer čísla
    int digit; //proměnná pro uložení právě zpracovan= číslice
    int multi = 1;

    // 2. Ošetření záporných čísel (znaménko nemá vliv na součet cifer)
    if (number < 0)
    {
        number = -number; //převedení čísla na kladné
    }
    else if (number == 0)
    {
        sum = 0; //součet cifer čísla 0 je 0
    }
    else
    {

        //Jádro problému - matematický rozklad čísla pomocí cyklu
        for (; number > 0; number = number / 10)
        {
            digit = number % 10;
            sum = sum + digit;
            multi = multi * digit;
        }
    }

    // 5. Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"Ciferný součet čísla {numberBackup} je: {sum} a součin je {multi}");
    Console.WriteLine("===========================");

    //Konec jádra konkrétního algoritmu
    
    // Konec jádra algoritmu - výpis řady
    

    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";

}