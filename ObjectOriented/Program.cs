using System;

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
                smiles[i] = new Smile();
                Console.WriteLine("Input X");
                smiles[i].X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Y");
                smiles[i].Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Face");
                smiles[i].Face = Console.ReadLine();
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
