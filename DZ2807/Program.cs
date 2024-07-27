using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DriveACar
{
    internal class Program
    {
        public class Team
        {
            public string Name = "Gryffindor";
            public int Points = 0;

            public void PrintInfo()
            {
                Console.WriteLine(Name + ":" + Points);
            }
        }

        public class Quidditch()
        {
            public Team RedTeam = new Team();
            public Team BlueTeam = new Team();

            public void ShowScore()
            {
                RedTeam.PrintInfo();
                BlueTeam.PrintInfo();
            }

            public void RedSnitch()
            {
                RedTeam.Points += 150;
                Console.WriteLine("Red Team Won!");
            }

            public void BlueSnitch()
            {
                BlueTeam.Points += 150;
                Console.WriteLine("Blue Team Won!");
            }
        }

        static void Main(string[] args)
        {
            Quidditch quidditch = new Quidditch();
            quidditch.RedTeam.Name = "Hufflepuff";
            quidditch.BlueTeam.Name = "Ravenclaw";
            quidditch.ShowScore();
            //Hufflepuff:0
            //Ravenclaw:0
            quidditch.RedTeam.Points += 10;
            quidditch.BlueTeam.Name = "Gryffindor";
            quidditch.ShowScore();
            //Hufflepuff:10
            //Gryffindor:0


        }

    }
}