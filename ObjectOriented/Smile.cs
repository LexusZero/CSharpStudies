using System;
namespace ObjectOriented
{
    class Smile
    {
        public int X;
        public int Y;
        public string Face;

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
