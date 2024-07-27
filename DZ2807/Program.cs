using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class Program
    {
        public class Counter
        {
            int value = 0;

            public void Increment()
            {
                value++;
            }

            public void Show()
            {
                Console.WriteLine("Текущее значение счетчика = " + value);
            }

            public void Reset()
            {
                value = 0;
            }

            public void StartFrom(int newValue)
            {
                value = newValue;
            }
        }

        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.StartFrom(5);
            counter.Show();
            counter.Increment();
            counter.Show();
        }

    }
}