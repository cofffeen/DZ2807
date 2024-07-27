using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveACar
{
    internal class Program
    {
        public class Car
        {
            public void Drive()
            {
                Console.WriteLine("Вын-вын!");
                Console.WriteLine();
                return;
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();

            car.Drive();
        }

    }
}