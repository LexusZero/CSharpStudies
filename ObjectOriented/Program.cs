using System;

namespace ObjectOriented
{
    class Program
    {
        // нельзя изменять
        static void Main()
        {
            Coords[] smileCoords = new Coords[] { new Coords(2, 4) };
            string[] smileFaces = new string[] { ":D" };

            Coords[] teleporterCoords = new Coords[] { new Coords(5, 1), new Coords(1, 5) };

            WorldMap worldMap = new WorldMap(smileCoords, smileFaces, teleporterCoords);
            while (true)
            {
                worldMap.Print();
                char move = Console.ReadKey().KeyChar;
                worldMap.Update(move);
            }
        }

        // TODO: удалить
        static void OldMain(string[] args)
        {
            Console.WriteLine("Input the number of smiles");
            int n = Convert.ToInt32(Console.ReadLine());
            IMoveable[] objectsWithCoordinates = new IMoveable[n + 2];
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

                    if (objectsWithCoordinates[current - 1].Coords == objectsWithCoordinates[n].Coords)
                    {
                        objectsWithCoordinates[current - 1].Coords = objectsWithCoordinates[n + 1].Coords;

                    }
                    else if (objectsWithCoordinates[current - 1].Coords == objectsWithCoordinates[n + 1].Coords)
                    {
                        objectsWithCoordinates[current - 1].Coords = objectsWithCoordinates[n].Coords;
                    }

                }


            }
        }

        private static void PrintObjectWithCoordinates(IMoveable coordinates)
        {
            Console.SetCursorPosition(coordinates.Coords.X, coordinates.Coords.Y);
            Console.Write(coordinates.ToString());
        }
    }
}
