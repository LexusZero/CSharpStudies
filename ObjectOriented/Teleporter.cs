using System;

namespace ObjectOriented
{
    // телепортирует на другой объект Teleporter
    class Teleporter : IMoveable
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