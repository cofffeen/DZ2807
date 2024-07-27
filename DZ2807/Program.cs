using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ
{
    internal class Program
    {
        public class Student
        {
            public string FirstName = "Неизвестное имя";
            public string LastName = "Неизвестная фамилия";
            public int Age = -1;
            public double Rating = 0.1;

            public void PrintSmallInfo()
            {
                Console.WriteLine(LastName + " " + FirstName[0] + ".");
            }

        }

        static void Main(string[] args)
        {
            Student s = new Student();
            s.FirstName = "Toyota";
            s.LastName = "Camry";
            s.Age = 3;
            Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Age);

            s.PrintSmallInfo();
        }

    }
}