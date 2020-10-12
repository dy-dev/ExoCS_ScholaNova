using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5, b = 6;

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
