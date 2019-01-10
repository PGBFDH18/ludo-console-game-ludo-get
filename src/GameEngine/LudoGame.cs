using System;

namespace GameEngine
{
    public class LudoGame
    {
        // Ta emot information från LudoGame library 
        public LudoGame()
        {
            // Extrahera informationen från parametern som Session tar emot.
            // Skapar spelare
            // Skapa pjäser för respektive spelare

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
