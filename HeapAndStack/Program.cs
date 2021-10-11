using System;

namespace HeapAndStack
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[2];
            int number = 0;

            Foo(arr, number);
            Console.WriteLine(arr[0]);
            Console.WriteLine(number);
        }

        static void Foo(int[] arr, int number)
        {
            arr[0] = 10;
            number = 10;
        }


        static void MainOld(string[] args)
        {
            Clazz clazz = new Clazz { Number = 1 };
            Structt structt = new Structt { Number = 1 };
            Structt structt2 = new Structt { Number = 2 };
            MethodThatChanges(clazz, structt, structt2);
            Console.WriteLine(clazz.Number);
            Console.WriteLine(structt.Number);

            Console.WriteLine(structt2.Number);
            structt2.Number = 3;
            Console.WriteLine(structt2.Number);
        }

        static void MethodThatChanges(Clazz clazz /* 8 byte */, Structt structt /* 10 byte */, Structt structt2)
        {
            clazz.Number = 5;
            Console.WriteLine("In method: " + clazz.Number);
            structt.Number = 5;
            Console.WriteLine("In method: " + structt.Number);
            structt2.Number = 7;
            Console.WriteLine("In method: " + structt2.Number);
        }
    }

    class Clazz // 10 byte
    {
        public int Number { get; set; }
    }

    struct Structt // 10 byte            
    {
        public int Number { get; set; }
    }
}
