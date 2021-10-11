using System;

namespace ObjectOriented.Classes
{
    // телепортирует на другой объект Teleporter
    class Teleporter : ICoordinates
    {
        public Coords Coords { get; set; }
        public Teleporter(int x, int y)
        {
            Coords = new Coords(x, y);
        }
        public void Move(char move)
        {
        }
        public override string ToString()
        {
            return "T";
        } 
    }
}