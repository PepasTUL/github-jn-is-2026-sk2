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
    

    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";

}