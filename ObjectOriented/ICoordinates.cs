namespace ObjectOriented.Classes
{
    interface ICoordinates
    {
        Coords Coords { get; set; }
       // int X { get; set; }
       // int Y { get; set; }

        void Move(char move);
    }
}