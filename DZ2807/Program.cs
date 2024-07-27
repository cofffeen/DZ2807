using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zebra
{
    internal class Program
    {
        public class Zebra
        {
            bool isWhite = true;
            public void DriGetStripe()
            {

                if (isWhite)
                {
                    Console.WriteLine("Полоска белая");
                }
                else
                {
                    Console.WriteLine("Полоска черная");
                }

                isWhite = !isWhite;
                return;
            }
        }

        static void Main(string[] args)
        {
            Zebra zebra1 = new Zebra();

            zebra1.DriGetStripe();
            zebra1.DriGetStripe();
            zebra1.DriGetStripe();

            Zebra zebra2 = new Zebra();
            zebra2.DriGetStripe();
        }

    }
}