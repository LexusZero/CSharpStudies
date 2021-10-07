using System;

namespace ObjectOriented.Classes
{
    // телепортирует на другой объект Teleporter
    class Teleporter : ICoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Teleporter(int x, int y)
        {
            this.X = x;
            this.Y = y;
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
            return "T";
        }
        public void Teleport(ICoordinates coordinates)
        {

        }
    }
}