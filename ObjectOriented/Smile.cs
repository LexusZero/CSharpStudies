using System;
namespace ObjectOriented.Classes
{
    class Smile : ICoordinates
    {
        public Coords Coords { get; set; }
        private readonly string face;

        public Smile(int x, int y, string face)
        {
            Coords = new Coords(x, y);
            this.face = face;
        }
        public void Move(char move)
        {
            Coords coords = Coords;
            if (move == 'w')
            {
                coords.Y--;
            }
            else if (move == 'a')
            {
                coords.X--;
            }
            else if (move == 's')
            {
                coords.Y++;
            }
            else if (move == 'd')
            {
                coords.X++;
            }
            Coords = coords;
        }
        public override string ToString()
        {
            return face;
        }

    }
}
