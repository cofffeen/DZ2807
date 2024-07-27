using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Selector
{
    internal class Program
    {
        public class Selector(int[] array)
        {
            public int[] Array = array;

            public void PrintOdds()
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] % 2 != 0)
                    {
                        Console.Write(Array[i] + " ");
                    }
                }
            }

            public void PrintEvens()
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] % 2 == 0)
                    {
                        Console.Write(Array[i] + " ");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Selector selector = new Selector(numbers);

            selector.PrintOdds(); // 1 3 5
            Console.WriteLine();
            selector.PrintEvens(); // 2 4 6

        }

    }
}