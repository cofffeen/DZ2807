using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Person
{
    internal class Program
    {
        public class Person(string UsersFirstName, string UsersSecondName, int usersAge)
        {
            public string FirstName = UsersFirstName;
            public string SecondName = UsersSecondName;
            public int age = usersAge;

            public string GetFullName()
            {
                return FirstName + " " + SecondName;
            }

            public bool IsAdult()
            {
                return age >= 18;
            }

        }

        static void Main(string[] args)
        {
            Person person = new Person("Иосиф", "Дзеранов", 26);
            Console.WriteLine(person.GetFullName()); // Дзеранов Иосиф
            Console.WriteLine(person.IsAdult()); // True

        }

    }
}