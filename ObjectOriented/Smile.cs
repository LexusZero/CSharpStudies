using System;
namespace ObjectOriented.Classes
{
    class Smile : object, ICoordinates
    {
        protected int x;
        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this.x = value;
            }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this.y = value;
            }
        }
        private readonly string face;
        private static int count;

        public int Id { get; private set; }

        public Smile(int x, int y, string face)
        {
            this.x = x;
            this.y = y;
            this.face = face;
            count++;
            Console.WriteLine("Numbers of smiles was created: " + count);
            Id = count;
        }
        public void Move(char move)
        {
            if (move == 'w')
            {
                y--;
            }
            else if (move == 'a')
            {
                X--;
            }
            else if (move == 's')
            {
                y++;
            }
            else if (move == 'd')
            {
                x++;
            }
        }
        public override string ToString()
        {
            return face;
        }

        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetX(int value)
        {
            if (value < 0)
            {
                return;
            }
            this.x = value;
        }
        public void SetY(int y)
        {
            if (y < 0)
            {
                return;
            }
            this.y = y;
        }

    }
}
