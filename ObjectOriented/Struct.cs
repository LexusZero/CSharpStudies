using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    struct Coords
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coords (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static bool operator ==(Coords c1, Coords c2)
        {
            return c1.X == c2.X && c1.Y == c2.Y;
        }
        public static bool operator !=(Coords c1, Coords c2)
        {
            return c1.X != c2.X || c1.Y != c2.Y;
        }
        public override bool Equals(object obj)
        {
            if (obj is Coords)
            {
                Coords coords = (Coords)obj;
                return this == coords;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return X + Y;
        }
    }
}
