using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine( "Donner le premier chiffre à prendre en compte");
        String var = Console.ReadLine();
        //int a = int.Parse(var); pas assez sécuriser, crash l'appli si var vaut "Toto"
        int.TryParse(var, out int a);
        
        
        Console.WriteLine( "Donner le deuxième chiffre chiffre à prendre en compte");
        var = Console.ReadLine();
        int.TryParse(var, out int b);

        Addition(a, b);
        Soustraction(a, b);
        Console.ReadLine();
    }

    /// <summary>
    /// Fonction d'addition entre 2 variable
    /// </summary>
    /// <param name="val1">Première variable qui sera additionné</param>
    /// <param name="val2">Deuxième variable servant dans l'opération</param>
    static void Addition(int val1, int val2)
    {
        String add = "Addition";
        Console.WriteLine("L'" + add + " entre " + val1 + " et " + val2 + " vaut " + (val1 + val2));

    }

    static void Soustraction(int val1, int val2)
    {
        String sub = "Soustraction";
        Console.WriteLine("La " + sub + " entre " + val1 + " et " + val2 + " vaut " + (val1 - val2));
    }
}
