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
            int x3 = 20;
            int y3 = 10;
            char current = '1';

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(":D");
                Console.SetCursorPosition(x2, y2);
                Console.Write(":c");
                Console.SetCursorPosition(x3, y3);
                Console.Write("D:");

                char move = Console.ReadKey().KeyChar;
                if (move == '1')
                {
                    current = '1';
                }
                else if (move == '2')
                {
                    current = '2';
                }
                else if (move == '3')
                {
                    current = '3';
                }

                if (current == '1')
                {


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
                else if (current == '2')
                {
                    if (move == 'w')
                    {
                        y2--;
                    }
                    else if (move == 'a')
                    {
                        x2--;
                    }
                    else if (move == 's')
                    {
                        y2++;
                    }
                    else if (move == 'd')
                    {
                        x2++;
                    }
                }
                else if (current == '3')
                {


                    if (move == 'w')
                    {
                        y3--;
                    }
                    else if (move == 'a')
                    {
                        x3--;
                    }
                    else if (move == 's')
                    {
                        y3++;
                    }
                    else if (move == 'd')
                    {
                        x3++;
                    }
                }
            }
        }

    }
}
