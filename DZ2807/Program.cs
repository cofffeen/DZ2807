using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FootballPlayer
{
    internal class Program
    {
        public class FootballPlayer(string name, string surname)
        {
            public string Name = name;
            public string Surname = surname;
            public int Goals = 0;
            public int Assists = 0;

            public void AddScore(int newGoals)
            {
                Goals += newGoals;
            }

            public void AddAssists(int newAssists)
            {
                Assists += newAssists;
            }


            public void ShowStatistics()
            {
                Console.WriteLine(Surname + " " + Name + " - голы: " + Goals + ", передачи: " + Assists);
            }

        }

        static void Main(string[] args)
        {
            FootballPlayer player1 = new FootballPlayer("Cristiano", "Ronaldo");
            player1.AddScore(711);
            player1.AddAssists(169);
            player1.ShowStatistics(); // Ronaldo Cristiano - голы: 711, передачи: 169

            FootballPlayer player2 = new FootballPlayer("Lionel", "Messi");
            player2.AddScore(682);
            player2.AddAssists(240);
            player2.ShowStatistics(); // Messi Lionel - голы: 682, передачи: 240

        }

    }
}