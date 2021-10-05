using System;
namespace ObjectOriented.Classes
{
    class Smile : object
    {
        protected int X;
        private int Y;
        private readonly string Face;
        private static int Count;
        public Smile(int x, int y, string face)
        {
            X = x;
            Y = y;
            Face = face;
            Count++;
            Console.WriteLine("Numbers of smiles was created: " + Count);

        }
        public void Move(char move)
        {
            if (move == 'w')
            {
                Y--;
            }
            else if (move == 'a')
            {
                X--;
            }
            else if (move == 's')
            {
                Y++;
            }
            else if (move == 'd')
            {
                X++;
            }
        }
        public override string ToString()
        {
            return Face;
        }

        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }

    }
}
