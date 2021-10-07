namespace ObjectOriented.Classes
{
    interface ICoordinates
    {
        int X { get; set; }
        int Y { get; set; }

        void Move(char move);
    }
}