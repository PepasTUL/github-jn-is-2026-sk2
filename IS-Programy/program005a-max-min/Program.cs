//jednořádkový komentář

/* toto
    je
    víceřádkový
    komentář
*/


//jako první si přpravýme smyčku pro opakování programu.

 string again = "a";
 //ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávaní "a" tak i "A"
while (again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************************");
    Console.WriteLine("************generátor - max a min + obrazexc**************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("***********************Josef Novák************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    
    
    //vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných čísel (kladné celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo! Zadejte počet generovaných čísel znovu (kladné celé číslo): ");
    }


    //vstup pro dolní mez
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte dolní mez znovu (celé číslo): ");
    }

    //vstup pro horní mez
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě hodnotě pro dolní mez): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní mez! Zadejte horní mez znovu (celé číslo): ");
    }



    // rekapitulace zadaných hodnot 
    Console.WriteLine();
    Console.WriteLine("================================");

    
    //vypis zadaných hodnot do jednoho řádku
    Console.WriteLine($"počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}; ");
    Console.WriteLine("================================");
    Console.WriteLine();
    
    //jádro konkrétního algoritmu

    //deklarace pole a alokace v paměti
    int[] myRandNumbs = new int[n];
    
    //inicializace generátoru náhodných čísel
    Random myRandNumb = new Random(); 
    // Random myRandNumb = new Random(50); // pevný seed pro testovací účely pro stejná čísla. 
    

    Console.WriteLine("Generovaná čísla: ");
    for(int i = 0; i < myRandNumbs.Length ; i++)
    {
        //generování i-tého náhodného čísla
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    //hledání maxima a minima a jejich umístění

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    for(int i = 1; i < n; i++)
    {
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"Maximum: {max} (pozice: {posMax})");
    Console.WriteLine($"Minimum: {min} (pozice: {posMin})");   
    Console.WriteLine("================================");
    Console.WriteLine();
    //konec jádra konkrétního algortimu

    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
   

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesu programu ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete spustit program znovu? ");
    again = Console.ReadLine() ?? "";
}