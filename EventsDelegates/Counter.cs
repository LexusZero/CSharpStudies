using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    delegate void CounterEvent(int count);

    class Counter
    {
        public event CounterEvent EvenCount;
        public event CounterEvent DevideByThree;
        private int count = 0;

        public void Increment()
        {
            count++;
            Console.WriteLine(count);
            if (count % 2 == 0)
            {
                EvenCount?.Invoke(count);
            }
            if (count % 3 == 0)
            {
                DevideByThree?.Invoke(count);
            }
        }
    }
}
