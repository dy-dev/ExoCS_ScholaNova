using System;
using System.Runtime.ExceptionServices;
using System.Text;

enum ListeExercices
{
    ADD_SUBSTRACT,
    GUESS_GAME,
    QUIT
}

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        while (!quit)
        {
            StringBuilder question = new StringBuilder("Que voulez vous faire :\n");
            question.Append("\t-1 Fonctions d'addition / Soustraction\n");
            question.Append("\t-2 Jeu de devinette\n");
            question.Append("\t-3 Quitter\n");
            ListeExercices typeExo = (ListeExercices)(GetUserInput(question.ToString()) - 1);

            switch (typeExo)
            {
                case ListeExercices.ADD_SUBSTRACT:
                    ExoAddSubstract();
                    break;
                case ListeExercices.GUESS_GAME:
                    GuessNumber();
                    break;
                case ListeExercices.QUIT:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Désolé je n'ai pas compris votre demande");
                    break;
            }
        }

    }

    private static void GuessNumber()
    {
        int i = 50;
        bool found = false;
        while (!found)
        {
            int prop = GetUserInput("Proposer un chiffre");
            if (prop > i)
            {
                Console.WriteLine("Trop grand");
            }
            else if (prop < i)
            {
                Console.WriteLine("Trop petit");
            }
            else
            {
                Console.WriteLine("Bravo");
                found = true;
            }
        }

        //Créer un jeu qui demande à l’utilisateur de deviner 
        //un nombre entre 0 et 100.
        //Dans cette version, le nombre sera écrit en dur et défini 
        //au moment de la compilation

        //Utiliser des fonctions pour les récupérations d’information 
        //de la part de l’utilisateur et les comparaisons

        //Si le chiffre donné par l'utilisateur est supérieur au chiffre à deviner
        //dire à l'utilisateur "Trop Grand"
        //Si il est plus petit lui dire "Trop petit"
        // Sinon lui dire bravo

        //Faire en sorte qu’à la fin du jeu l’utilisateur 
        //puisse rejouer si il le souhaite

    }

    static int GetUserInput(String s)
    {
        Console.WriteLine(s);
        String var = Console.ReadLine();
        //int a = int.Parse(var); pas assez sécuriser, crash l'appli si var vaut "Toto"
        int.TryParse(var, out int result);
        return result;
    }

    private static void ExoAddSubstract()
    {
        int a = GetUserInput("Donner le premier chiffre à prendre en compte");
        int b = GetUserInput("Donner le deuxième chiffre chiffre à prendre en compte");

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
