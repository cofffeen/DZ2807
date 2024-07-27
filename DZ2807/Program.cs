using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dog
{
    internal class Program
    {
        public class Dog(string name, int age)
        {
            public string Name = name;
            public int Age = age;

            public string GetDescription()
            {
                return Name + " is " + Age + " years old";
            }

            public string Speak(string sound)
            {
                return Name + " says " + sound;
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog("Песик", 2);
            Console.WriteLine(dog.GetDescription()); // Песик is 2 years old
            Console.WriteLine(dog.Speak("Woof Woof")); // Песик says Woof Woof
            Console.WriteLine(dog.Speak("Bow Wow")); // Песик says Bow Wow

        }

    }
}