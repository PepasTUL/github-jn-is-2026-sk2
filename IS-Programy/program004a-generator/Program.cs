﻿//jednořádkový komentář

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
    Console.WriteLine("************generátor pseudonáhodných čísel***************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("***********************Josef Novák**********************");
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
    

    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
   

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesu programu ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete spustit program znovu? ");
    again = Console.ReadLine() ?? "";
}