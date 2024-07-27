using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveACar
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


        }

        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Show();
            counter.Increment();
            counter.Show();
        }

    }
}