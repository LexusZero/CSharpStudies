namespace ObjectOriented
{
    interface IMoveable
    {
        Coords Coords { get; set; }
        void Move(char move);
    }
}