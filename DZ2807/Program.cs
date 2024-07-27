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
        public class City
        {
            public string Name = "Неизвестное имя";
            public GeoLocation Location = new GeoLocation();

        }

        public class GeoLocation
        {
            public double Latitude = 0;
            public double Longitude = 0;

        }

        static void Main(string[] args)
        {
            City city = new City();
            city.Name = "Vladikavkaz";

            city.Location = new GeoLocation();
            city.Location.Latitude = 43.0348;
            city.Location.Longitude = 44.6798;

            Console.WriteLine($"I love {city.Name} located at ({city.Location.Longitude}, {city.Location.Latitude})");
        }

    }
}