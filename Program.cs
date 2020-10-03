using System;

namespace jeux_de_des
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Voici le Tirage de dés");

            bool continuer = true;
            Random rand = new Random();
            while (continuer)
            {
                int aleatoire = rand.Next(1, 7);
                Console.WriteLine("J'ai fait un " + aleatoire);


                Console.WriteLine("Voulez-vous continuer ? (oui/non)");
                string reponce = Console.ReadLine();
                if (reponce.Equals("non"))
                {
                    continuer = false;
                }
            }
        }
    }
}
