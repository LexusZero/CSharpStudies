using System;
using ObjectOriented.Classes;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the number of smiles");
            int n = Convert.ToInt32(Console.ReadLine());
            Smile[] smiles = new Smile[n];
            for (int i = 0; i < smiles.Length; i++)
            {

                Console.WriteLine("Input X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Y");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Face");
                string face = Console.ReadLine();
                smiles[i] = new Smile(x, y, face);
            }
            int current = 1;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < smiles.Length; i++)
                {
                    smiles[i].Print();
                }

                char move = Console.ReadKey().KeyChar;

                if (char.IsDigit(move))
                {

                    current = move - '0';
                }

                if (current > 0 && current <= n)
                {
                    smiles[current - 1].Move(move);
                }


            }
        }
    }
}
