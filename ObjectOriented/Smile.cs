using System;
namespace ObjectOriented.Classes
{
    class Smile
    {
        private int X;
        private int Y;
        private readonly string Face;
        private static int Count;
        public Smile(int x, int y, string face)
        {
            X = x;
            Y = y;
            Face = face;
            Count++;
            Console.WriteLine("Numbers of smiles was created: " +Count);
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


        //public void Print(int x, int y, string face)
        public void Print()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Face);
           // Реализовать этот метод
        }
    }
}
