using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Smile smile = new Smile();
            smile.X = 0; 
            smile.Y = 0;
            smile.Face = ":D";
            Smile smile2 = new Smile();
            smile2.X = 10;
            smile2.Y = 10;
            smile2.Face = ":c";
            Smile smile3 = new Smile();
            smile3.X = 20;
            smile3.Y = 10;
            smile3.Face = "D:";
            int current = 1;

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < smiles.Length; i++)
                {
                    smiles[i].Print();
                }
                //smile.Print();
                //smile2.Print();
                //smiles[n].Print();

                char move = Console.ReadKey().KeyChar;
              
                if (char.IsDigit(move))
                {
                    current = move;
                }

                if (current > 0 && current <= n)
                {
                    smiles[n - 1].Move(move);
                }
                //else if (current == '2')
                //{
               //     smile2.Move(move);
                //}
                //else if (current == '3')
               // {
                //    smile3.Move(move);
                //}
                 
            }
        }
    }
}
