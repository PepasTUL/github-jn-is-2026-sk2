string again = "a";
// .ToLower() - převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a"){



    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Název prgramu******************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Josef Novák*****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");

    // Vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první hodnotu (celé číslo):");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Zadaná hodnota není celé číslo. Zadejte prosím znovu:");
    }

    // Vstup konečné hodnoty - správně řešený
   // Console.Write("Zadejte poslední hodnotu (celé číslo):");
   // int bbb;
   // while (!int.TryParse(Console.ReadLine(), out bbb))
   // {
   //     Console.WriteLine("Zadaná hodnota není celé číslo. Zadejte prosím znovu:");
   // }


    // Výpis zadaných hodnot v jedné řádce
    //Console.WriteLine("===========================");
    //Console.WriteLine($"První hodnota: {number}, poslední hodnota: {bbb}");
    //Console.WriteLine("===========================");

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

    // 3. zvláštní případ
    if (number == 0)
    {
        sum = 0; //součet cifer čísla 0 je 0
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na jednotlivé číslice");

        //Jádro problému - matematický rozklad čísla pomocí cyklu
        while(number > 0 )
        {
            //Operátoru % se říká Modulo (slouží k určení zbytku po dělení)
            digit = number % 10; //MODULO 1O získá poslední číslici
            sum = sum + digit;   // Přičtení cifry k celkovému součtu
            number = number / 10;  // Celočíselné dělení 10 odstraní poslední číslici
            multi = multi * digit; // Přičtení cifry k celkovému součinu
            

            Console.WriteLine($"Aktuální číslice (zbytek): {digit}");
            Console.WriteLine($"Číslo po odříznutí aktuální číslice: {number}");
            Console.WriteLine($"Aktuální hodnota ciferného součtu: {sum}");
            Console.WriteLine($"Aktuální hodnota ciferného součinu: {multi}");
        }
    }

    // 5. Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"Ciferný součet čísla {numberBackup} je: {sum}");
    Console.WriteLine("===========================");
    Console.WriteLine($"Ciferný součin čísla {numberBackup} je: {multi}");
    Console.WriteLine("===========================");
    Console.WriteLine();

    //Konec jádra konkrétního algoritmu
    
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