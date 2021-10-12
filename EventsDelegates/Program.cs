using System;

namespace EventsDelegates
{
    delegate double Calculation(double a, double b);

    class Program
    {
        static void Main()
        {
            SubscribeUnsubscribe();
        }

        static void LamdaExample()
        {
            Calculation calculation = (a, b) => a + b;
            PrintCalculation(calculation, 1, 2);
        }

        static void SubscribeUnsubscribe()
        {
            Counter counter = new Counter();
            counter.EvenCount += Counter_EvenCount;
            counter.EvenCount += Counter_EvenCount2;
            counter.DevideByThree += Counter_DivisibleByThree;
            counter.DevideByThree += delegate (int count)
            {
                Console.WriteLine("Anonymous method");
            };
            for (int i = 0; i < 8; i++)
            {
                counter.Increment();
            }
            counter.EvenCount -= Counter_EvenCount2;
            for (int i = 0; i < 5; i++)
            {
                counter.Increment();
            }
        }

        private static void Counter_DivisibleByThree(int count)
        {
            Console.WriteLine("Count is divisible by three");
        }

        private static void Counter_EvenCount2(int count)
        {
            Console.WriteLine("But what is the value");
        }

        private static void Counter_EvenCount(int count)
        {
            Console.WriteLine("Count was even!");
        }

        // Функции высшего порядка
        static void PrintCalculation(Calculation calculation, double a, double b)
        {
            string calculationName = calculation.Method.Name;
            Console.WriteLine($"We are doing {calculationName} on a = {a} and b = {b}");
            double result = calculation(a, b);
            Console.WriteLine($"The result is {result}");
        }

        static double Addition(double a, double b)
        {
            return a + b;
        }

        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Substraction(double a, double b)
        {
            return a - b;
        }

        static double Addition(double a, double b, double c)
        {
            return a + b + c;
        }

        static void PrintNumber(double a)
        {
            Console.Write(a);
        }
    }
}
