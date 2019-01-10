using System;

namespace GameEngine
{
    public class LudoGame
    {

        Player player = new Player();
        // Ta emot information från LudoGame library 
        public LudoGame(string[][] players)
        {
            // Extrahera informationen från parametern som Session tar emot.
            // Skapar spelare
            // Skapa pjäser för respektive spelare
            int len = players.Length;

            for (int i = 0; i < len; i++)
            {
                string name = players[i][0];
                string color = players[i][1];


                player = new Player
                {
                    Name = name,
                    Color = color
                };
            }

            Run();
        }

        // Inf-loop där vi slår tärningar.
        public void Run()
        {
        }

        public void StartGame(int numberOfPlayers)
        {
            Console.WriteLine($"Game started with {numberOfPlayers} players");
        }
    }
}
