using System;


namespace GameEngine
{
    public class LudoGame
    {
        Player player = new Player();
        Piece piece = new Piece();
        // Ta emot information från LudoGame library 
        public LudoGame(string[][] players)
        {
            // Extrahera informationen från parametern som Session tar emot.
            // Skapar spelare
            // Skapa pjäser för respektive spelare
            int len = players.Length;
            Player[] totalplayers = new Player[len];

            for (int i = 0; i < len; i++)
            {
                player = new Player
                {
                    Name = players[i][0],
                    Color = players[i][1]
                };
                totalplayers[i] = player;
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