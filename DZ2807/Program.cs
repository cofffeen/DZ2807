using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Point
{
    internal class Program
    {
        public class Point(int x, int y)
        {
            public int X = x;
            public int Y = y;

            public string Print()
            {
                return "(" + X + "," + Y + ")";
            }

            public double CalculateDistance(Point otherPoint)
            {
                return Math.Sqrt((otherPoint.X - this.X) * (otherPoint.X - this.X) + (otherPoint.Y - this.Y) * (otherPoint.Y - this.Y));
            }


        }

        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            Console.WriteLine(p1.Print()); // распечатает (1,2)
            Point p2 = new Point(4, 6);
            Console.WriteLine(p2.Print()); // распечатает (4,6)
            Console.WriteLine(p1.CalculateDistance(p2)); // распечатает 5
            Console.WriteLine(p2.CalculateDistance(p1)); // распечатает 5

        }

    }
}