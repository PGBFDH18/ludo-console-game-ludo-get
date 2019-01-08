using System;
using GameEngine;

namespace LudoGame
{
    class Program
    {
        static int numberOfPlayers;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ludo!");

            while (numberOfPlayers <= 1 || numberOfPlayers >= 5)
            {
                Console.WriteLine("Number of players:");
                numberOfPlayers = int.Parse(Console.ReadLine());

                if (numberOfPlayers <= 1)
                {
                    Console.WriteLine("Must be more than 2 players");
                }
                else if (numberOfPlayers >= 5)
                {
                    Console.WriteLine("Maximum 4 players");
                }
            }
            var game = new GameEngine.LudoGame();
            game.StartGame(numberOfPlayers);
        }
    }
}
