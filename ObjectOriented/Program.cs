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
            // Избавиться от x3 и y3 (заменить на объект класса Smile, можно назвать smile3)
            int x3 = 20; 
            int y3 = 10;
            char current = '1';

            while (true)
            {
                Console.Clear();
                // Заменить эти строчки на вызов Smile.Print
                Console.SetCursorPosition(smile.X, smile.Y);
                Console.Write(smile.Face);
                Console.SetCursorPosition(smile2.X, smile2.Y);
                Console.Write(smile2.Face);
                Console.SetCursorPosition(x3, y3);
                Console.Write("D:");

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
