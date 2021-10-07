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
            ICoordinates[] objectsWithCoordinates = new ICoordinates[n + 2];
            for (int i = 0; i < objectsWithCoordinates.Length - 2; i++)
            {

                Console.WriteLine("Input X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Y");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Face");
                string face = Console.ReadLine();
                objectsWithCoordinates[i] = new Smile(x, y, face);
            }
            for (int i = n; i < objectsWithCoordinates.Length; i++)
            {
                Console.WriteLine("Teleporters");
                Console.WriteLine("Input X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Y");
                int y = Convert.ToInt32(Console.ReadLine());
                objectsWithCoordinates[i] = new Teleporter(x, y);

            }

            int current = 1;
            
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < objectsWithCoordinates.Length; i++)
                {
                    PrintObjectWithCoordinates(objectsWithCoordinates[i]);
                }

                char move = Console.ReadKey().KeyChar;

                if (char.IsDigit(move))
                {

                    current = move - '0';
                }

                if (current > 0 && current <= n + 2)
                {
                    objectsWithCoordinates[current - 1].Move(move);

                    if (objectsWithCoordinates[current - 1].X == objectsWithCoordinates[n].X && objectsWithCoordinates[current - 1].Y == objectsWithCoordinates[n].Y)
                    {
                        objectsWithCoordinates[current - 1].X = objectsWithCoordinates[n + 1].X;
                        objectsWithCoordinates[current - 1].Y = objectsWithCoordinates[n + 1].Y;
                        
                    }
                    else if (objectsWithCoordinates[current - 1].X == objectsWithCoordinates[n + 1].X && objectsWithCoordinates[current - 1].Y == objectsWithCoordinates[n + 1].Y)
                    {
                        objectsWithCoordinates[current - 1].X = objectsWithCoordinates[n].X;
                        objectsWithCoordinates[current - 1].Y = objectsWithCoordinates[n].Y;
                    }
                        
                }


            }
        }

        private static void PrintObjectWithCoordinates(ICoordinates coordinates)
        {
            Console.SetCursorPosition(coordinates.X, coordinates.Y);
            Console.Write(coordinates.ToString());
            
        }
    }
}
