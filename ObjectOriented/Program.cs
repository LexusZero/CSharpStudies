using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int x2 = 10;
            int y2 = 10;
            char current = '1';
            
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(":D");
                Console.SetCursorPosition(x2, y2);
                Console.Write(":c");
     
                char move = Console.ReadKey().KeyChar;

                if (move == 'w')
                {
                    y--;
                }
                else if (move == 'a')
                {
                    x--;
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
        }
    }
}
