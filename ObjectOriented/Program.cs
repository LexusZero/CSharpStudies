using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Smile smile = new Smile();
            smile.X = 0; 
            smile.Y = 0;
            smile.Face = ":D";
            Smile smile2 = new Smile();
            smile2.X = 10;
            smile2.Y = 10;
            smile2.Face = ":c";
            Smile smile3 = new Smile();
            smile3.X = 20;
            smile3.Y = 10;
            smile3.Face = "D:";
            char current = '1';

            while (true)
            {
                Console.Clear();
                smile.Print();
                smile2.Print();
                smile3.Print();

                char move = Console.ReadKey().KeyChar;
              
                if (char.IsDigit(move))
                {
                    current = move;
                }

                if (current.Equals('1'))
                {
                    smile.Move(move);
                }
                else if (current == '2')
                {
                    smile2.Move(move);
                }
                else if (current == '3')
                {
                    smile3.Move(move);
                }
                 
            }
        }
    }
}
