using System;
using System.Collections.Generic;
using System.IO;
using GameEngine;

namespace LudoGame
{
    internal class Program
    {
        private static List<string> alternative = new List<string>();
        private static List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow" };
        private static int numberOfPlayers;
        private static string[][] players;
        private static Session S;

        private static void Main(string[] args)
        {
            PrintWelcomeText();
            SetNumberOfPlayers();
            SetPlayers();
            S = new Session(players);
            //  game.StartGame(players);

            Run();
        }

        private static void PrintWelcomeText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var logo = File.ReadAllLines(@"Logo.txt");
            foreach (var item in logo)
                Console.WriteLine(item);
        }

        private static void Run()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), S.GetCurrentPlayer());
            Console.WriteLine("");
            Console.WriteLine("What do you wanna do?");
            Console.WriteLine("1: See who's turn it is.");
            Console.WriteLine("2: Look at current playingfield.");
            Console.WriteLine("3: Roll dice.");
            //Console.WriteLine("4: Roll dice.");
            //Console.WriteLine("5: Roll dice.");
            //Console.WriteLine("6: Roll dice.");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                string p = S.GetCurrentPlayer();
                Console.WriteLine($"It's {p}:s turn!");
                Run();
            }
            else if (choice == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("x------x---xx-------");
                Console.WriteLine("");

                Run();
            }
            else if (choice == 3)
            {
                alternative = S.PlayerRoll();
                if (Convert.ToInt32(alternative[0]) == 6)
                {
                    Console.WriteLine("Would you like to move a new piece out of the nest?");
                    string tmp = Console.ReadLine();
                    // Roll again etc.
                }
                else
                {
                    // If number of pieces in play is greater than 1,
                    // display mentioned pieces and request Piece ID from user.
                    // Call a function that takes the roll and a Piece ID(number) as parameter.
                    Console.WriteLine(S.GetCurrentPlayer() + " player rolled: " + alternative[0]);
                    S.MovePiece(Convert.ToInt32(alternative[0]), 0);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void SetNumberOfPlayers()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            while (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                Console.WriteLine("Input numbers of players:");
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());

                    if (numberOfPlayers < 2)
                        Console.WriteLine("Must be more atleast 2 players");
                    else if (numberOfPlayers > 4)
                        Console.WriteLine("Maximum 4 players");
                }
                catch (Exception)
                {
                    Console.WriteLine("Number of players must be a digit");
                }
            }
            players = new string[numberOfPlayers][];
        }

        private static void SetPlayers()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("\r\nInput player {0}:s name:", i + 1);
                Console.WriteLine("");
                var name = Console.ReadLine();
                Console.WriteLine("\r\nPlease select player {0}:s color", i + 1);
                Console.WriteLine("");

                for (int j = 0; j < colors.Count; j++)
                {
                    Console.WriteLine("{0}. {1}", j + 1, colors[j]);
                }
                try
                {
                    int colorIndex = int.Parse(Console.ReadLine());
                    players[i] = new string[] { name, colors[colorIndex - 1] };
                    colors.RemoveAt(colorIndex - 1);
                }
                catch (Exception)
                {
                    Console.WriteLine("Selected color must be a digit.");
                }
            }
        }
    }
}