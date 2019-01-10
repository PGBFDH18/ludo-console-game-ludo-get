using System;


namespace GameEngine
{
    public class Session
    {
        Player player = new Player();
        Piece piece = new Piece();

        // Ta emot information från LudoGame
        public Session(string[][] players, string startingColor)
        {
            // Extrahera informationen från parametrarna som Session tar emot.
            int len = players.Length;
            Player[] totalPlayers = new Player[len];

            for (int i = 0; i < len; i++)
            {
                player = new Player
                {
                    Name = players[i][0],
                    Color = players[i][1]
                };
                totalPlayers[i] = player;
                for (int j = 0; j < 4; j++)
                {
                    piece = new Piece
                    {
                        Color = players[i][1],
                        Number = j
                    };
                    player.pieces[i] = piece;
                }
            }
            Run();
        }

        // Inf-loop där vi slår tärningar.
        public void Run()
        {

        }
    }
}