using System;

namespace plus_ou_moin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // message d'acceuil
            Console.WriteLine("Voici le jeux du plus ou moins");
;            // nombre aleatoie
            Random rand = new Random();
            int cible = rand.Next(1, 101);

            bool trouver = false;
            int nbEssais = 0;
            // tant que l'utilisateur n'a pas trouver
            while (!trouver)
            {
                Console.WriteLine("Propose-moi un nombre");
                int proposition;

                if (int.TryParse(Console.ReadLine(), out proposition))
                {
                    nbEssais++;
                    if (proposition > cible)

                    {
                        Console.WriteLine("C'est moins   !");

                    }
                    else if (proposition < cible)
                    {

                        Console.WriteLine("C'est plus!");
                    }
                    else
                    {
                        Console.WriteLine("Bravo tu as trouvé en " + nbEssais + " coups !");
                        trouver = true;

                    }
                }

            }
            // on luis demande un nombre
            // si c'est un nombre correct
            // on luis dit si c'est plus ou moins
            // on incrémente son nombre d'essai
            // s'il a trouvé : on lui affiche un message et on s'arrête

            // fin du programme
            Console.ReadKey();
        }
    }
}
