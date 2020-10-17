using System;

namespace Test
{
    class MainClass
    {
        public static void Main()
        {
            int[] tab = new int[3];

             for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = 3 * i;
            }
            foreach (int nb in tab) {
                Console.WriteLine(nb);
            }

                Console.ReadKey();
        }
    }
}
