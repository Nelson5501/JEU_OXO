using System;

namespace Jeu_OXO
{
    class MainClass
    {
        enum Etatcase
        {
            vide,
            rond,
            croix
        }

        static Etatcase[,] grille; // grille de 3 * 3
        static Random generateur; // generateur aléatoire

        public static void Main(string[] args)
        {
            // Message d'acceuil

            Console.WriteLine("Bienvenue dans le jeu du OXO");

            // Initialiaser les variables

            bool finDeJeu = false;
            grille = new Etatcase[3, 3];
            int nbvide = 9;
            generateur = new Random();
            
            // Afichier la grille
            AffichageGrille();

            // Boucle Principale
            while (!finDeJeu)
            {
                // Jeu de l'utilisateur
                ChoisirCaseUtilisateur();
                nbvide--;

                // Jeu Gagnant ?
                bool gagne = JeuGagnant(Etatcase.croix);
                if (gagne)
                {
                    finDeJeu = true;
                    Console.WriteLine("Bravo ! tu as gagner ! ");

                }
                // Jeu de l'ordinateur
                if (!finDeJeu && nbvide > 0)
                {
                    ChoisirCaseOrdinateur();
                    nbvide--;
                
                // Affichage de la grille
                Console.WriteLine("l'ordi a jouer : ");
                AffichageGrille();

                    // Jeu Gagnant
                    if (!finDeJeu(Etatcase.rond))
                    {
                    }
                    else
                    {
                        finDeJeu = true;
                        Console.WriteLine("Desoler la maschine a gagner ! ");

                    }
                }
                // match nul
                if (nbvide == 0)
                {
                    Console.WriteLine("Match nul pas de chance ");
                    finDeJeu = true;

                }

            }

        }

        private static bool JeuGagnant(Etatcase croix)
        {

            // cas ligne :
            for (int ligne = 0; ligne < 3; ligne++)
            {
                if (grille[ligne, 0] == Etatcase && grille[ligne, 1] == Etatcase && grille[ligne, 2] == Etatcase)
                {
                    return true;
                }
            }

            for (int colonne = 0; colonne < 3; colonne++)

                // cas colonne :
                if (grille[0, colonne] == Etatcase && grille[1, colonne] == Etatcase && grille[2, colonne] == Etatcase)
            {
                return true;

            }

            // cas diagonale :
            if (grille[2,0 ] == Etatcase && grille[1,1] == Etatcase && grille[0,2] == Etatcase)
            {
                return true;
            }

            // par default, on n'a pas gagné 
            return false;
        }

        private static void ChoisirCaseOrdinateur()
        {
            // boucle tant que le choix n'ai pas correct
            bool choixOK = false;

            while (!choixOK)
            {
                // choix des coordonnées
                int ligne = generateur.Next(0, 3);
                int colone = generateur.Next(0, 3);

                if (grille[ligne, colone] == Etatcase.vide)
                {
                    grille[ligne, colone] = Etatcase.rond;
                    choixOK = true;

                }
            }
        }

        private static void ChoisirCaseUtilisateur()
        {
            // on boucle jusqu'a choix correct
            bool ChoixOk = false;

            while (!ChoixOk)
            {
                // Message
                Console.WriteLine("Donnez votre choix de case");
                //Récuperation de la réponse
                string reponse = Console.ReadLine();
                int choix;

                // Convertir ver entier

                if (int.TryParse(reponse, out choix) && choix >= 0 && choix <= 8)
                {
                    int ligne = choix / 3;
                    int colonne = choix % 3;

                    if(grille[ligne, colonne] == Etatcase.vide)
                    {
                        // choix ok, je valide
                        grille[ligne, colonne] = Etatcase.croix;
                        ChoixOk = true;
                    }
                }
            }
        }
        private static void AffichageGrille()

        {
            String dessinGrille = "\n";
            
            //Trait du haut
            dessinGrille += "*******\n";

            // Pour chaque ligne
            for (int ligne = 0; ligne < 3; ligne++)
            {
                dessinGrille += "|";

                // Pour chaque colone
                for (int colonne = 0; colonne < 3; colonne++)
                {
                    switch (grille[ligne, colonne])
                    {
                        case Etatcase.vide:
                            dessinGrille += ligne * 3 + colonne;
                            break;
                         case Etatcase.croix:
                            dessinGrille += "X";
                            break;
                        case Etatcase.rond:
                            dessinGrille += "O";

                            break;

                    }
                    dessinGrille += "|";
                }
                dessinGrille += "\n*******\n";

            }
            // affichae en console
            Console.WriteLine(dessinGrille);
            Console.ReadKey();

        }
    }
}
