using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5, b = 6;
        String add = "Addition";
        String sub = "Soustraction";

        Console.WriteLine("L'" + add + " entre " + a + " et " + b + " vaut " + (a + b));
        Console.WriteLine("La " + sub  + " entre " + a + " et " + b + " vaut " + (a - b));
        Console.ReadLine();
    }
}
