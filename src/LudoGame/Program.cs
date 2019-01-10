using System;
using GameEngine;

namespace LudoGame
{
    internal class Program
    {
        private static int numberOfPlayers;

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ludo!");

            while (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                Console.WriteLine("Number of players:");
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());

                    if (numberOfPlayers < 2)
                    {
                        Console.WriteLine("Must be more atleast 2 players");
                    }
                    else if (numberOfPlayers > 4)
                    {
                        Console.WriteLine("Maximum 4 players");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Number of players must be a digit");
                }
            }

            var game = new GameEngine.LudoGame();
            game.StartGame(numberOfPlayers);
        }
    }
}