using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 45 - list of objects

            // Create a list
            List<Player> players = new List<Player>();

            /*
            Player player1 = new Player("Phil");
            Player player2 = new Player("Loz");
            Player player3 = new Player("Nick");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            */

            players.Add(new Player("Phil"));
            players.Add(new Player("Loz"));
            players.Add(new Player("Nick"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }

    class Player
    {
        public String username;
        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }

}